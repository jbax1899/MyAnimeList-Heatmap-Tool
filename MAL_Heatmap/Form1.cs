using JikanDotNet;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MAL_Heatmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString(), "*.html");
            System.Diagnostics.Debug.WriteLine("Found " + filePaths.Length + " html files");
            System.Diagnostics.Debug.WriteLine("Searching for usernames...");

            List<string> usernames = new List<string>();

            string searchFor = "\"picSurround\"><a href=\"/profile/";
            foreach (string filePath in filePaths)
            {
                StreamReader file = new StreamReader(filePath);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    int index = line.IndexOf(searchFor);    //find where the username should be
                    if (index != -1)
                    {
                        string username = "";
                        for (int i = index + searchFor.Length; i < line.Length; i++)   //record username, up until the first double quotation mark
                        {
                            if (line[i] != '\"')
                                username += line[i];
                            else
                                break;
                        }
                        usernames.Add(username);
                    }
                }
                file.Close();
            }
            System.Diagnostics.Debug.WriteLine("Done! Found " + usernames.Count + " usernames");
            label_usernameCount.Text = "Count: " + usernames.Count.ToString();

            string list = "";
            foreach (string username in usernames)
            {
                list += username + "\n";
            }
            richTextBox_usernames.Text = list;
        }

        private void button_run2_Click(object sender, EventArgs e)
        {
            if (textBox_anime.Text != "")
                Run(textBox_anime.Text);
            else
                MessageBox.Show("You must specify an anime.");
        }

        public async void Run(string animeSearchFor)
        {
            IJikan jikan = new Jikan(true);

            //What anime are we looking for?
            AnimeSearchResult animeSearchResult = await jikan.SearchAnime(animeSearchFor);
            string title = animeSearchResult.Results.First().Title;
            Int64 id = animeSearchResult.Results.First().MalId;
            textBox_found.Text = title + " (ID: " + id.ToString() + ")";

            //Ok, now look for that in each person's list
            List<int> scores = new List<int>();
            string scoresList = "";
            int scanned = 0;
            string current = "";
            using (var reader = new StringReader(richTextBox_usernames.Text))
            {
                for (string username = reader.ReadLine(); username != null; username = reader.ReadLine())
                {
                    if (scores.Count != numericUpDown_stopAt.Value)
                    {
                        try
                        {
                            Thread.Sleep(1000); //rate limiting
                            scanned++;
                            label_scanned.Text = "Scanned: " + scanned.ToString();
                            current = username;

                            UserAnimeList animeList = await jikan.GetUserAnimeList(username);   //pull up their anime list
                            foreach (var anime in animeList.Anime)  //Try to find the target anime. If found, record score
                            {
                                if (anime.MalId == id)
                                {
                                    if (anime.Score != 0)   //a score of 0 means it wasn't scored at all (left empty)
                                    {
                                        scores.Add(anime.Score);
                                        scoresList += (username + ": " + anime.Score + "\n");
                                        break;
                                    }
                                }
                            }
                        }
                        catch
                        {
                            System.Diagnostics.Debug.WriteLine("An error occurred while trying finding an anime list. The user (" + current + ") may not exist. ");
                        }
                    }
                    else
                        break;
                }
            }
            richTextBox_scores.Text = scoresList;

            //now print the results
            string results = "";
            double average = 0;
            foreach(int score in scores)
            {
                results += score.ToString() + ",";
                average += score;
            }
            richTextBox_results.Text = results;
            label_scoresCount.Text = scores.Count.ToString();
            label_average.Text = "Average: " + Math.Round(average / scores.Count, 2).ToString();

            MessageBox.Show("Done!");
        }
    }
}