namespace MAL_Heatmap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_usernameCount = new System.Windows.Forms.Label();
            this.richTextBox_usernames = new System.Windows.Forms.RichTextBox();
            this.button_run2 = new System.Windows.Forms.Button();
            this.textBox_anime = new System.Windows.Forms.TextBox();
            this.textBox_found = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_average = new System.Windows.Forms.Label();
            this.richTextBox_results = new System.Windows.Forms.RichTextBox();
            this.label_scanned = new System.Windows.Forms.Label();
            this.label_scoresCount = new System.Windows.Forms.Label();
            this.richTextBox_scores = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_stopAt = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopAt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given a folder of MAL user pages, extracts usernames.";
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(109, 49);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 1;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_usernameCount);
            this.groupBox1.Controls.Add(this.richTextBox_usernames);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_run);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Usernames";
            // 
            // label_usernameCount
            // 
            this.label_usernameCount.AutoSize = true;
            this.label_usernameCount.Location = new System.Drawing.Point(7, 401);
            this.label_usernameCount.Name = "label_usernameCount";
            this.label_usernameCount.Size = new System.Drawing.Size(43, 15);
            this.label_usernameCount.TabIndex = 5;
            this.label_usernameCount.Text = "Count:";
            // 
            // richTextBox_usernames
            // 
            this.richTextBox_usernames.Location = new System.Drawing.Point(7, 94);
            this.richTextBox_usernames.Name = "richTextBox_usernames";
            this.richTextBox_usernames.Size = new System.Drawing.Size(289, 304);
            this.richTextBox_usernames.TabIndex = 4;
            this.richTextBox_usernames.Text = "";
            // 
            // button_run2
            // 
            this.button_run2.Location = new System.Drawing.Point(313, 52);
            this.button_run2.Name = "button_run2";
            this.button_run2.Size = new System.Drawing.Size(75, 23);
            this.button_run2.TabIndex = 3;
            this.button_run2.Text = "Run";
            this.button_run2.UseVisualStyleBackColor = true;
            this.button_run2.Click += new System.EventHandler(this.button_run2_Click);
            // 
            // textBox_anime
            // 
            this.textBox_anime.Location = new System.Drawing.Point(18, 22);
            this.textBox_anime.Name = "textBox_anime";
            this.textBox_anime.Size = new System.Drawing.Size(289, 23);
            this.textBox_anime.TabIndex = 4;
            // 
            // textBox_found
            // 
            this.textBox_found.Location = new System.Drawing.Point(18, 52);
            this.textBox_found.Name = "textBox_found";
            this.textBox_found.ReadOnly = true;
            this.textBox_found.Size = new System.Drawing.Size(289, 23);
            this.textBox_found.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_stopAt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_average);
            this.groupBox3.Controls.Add(this.richTextBox_results);
            this.groupBox3.Controls.Add(this.label_scanned);
            this.groupBox3.Controls.Add(this.label_scoresCount);
            this.groupBox3.Controls.Add(this.richTextBox_scores);
            this.groupBox3.Controls.Add(this.textBox_anime);
            this.groupBox3.Controls.Add(this.textBox_found);
            this.groupBox3.Controls.Add(this.button_run2);
            this.groupBox3.Location = new System.Drawing.Point(320, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 451);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Rate Limiter: 0.5 query/s)";
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Location = new System.Drawing.Point(18, 419);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(53, 15);
            this.label_average.TabIndex = 5;
            this.label_average.Text = "Average:";
            // 
            // richTextBox_results
            // 
            this.richTextBox_results.Location = new System.Drawing.Point(18, 249);
            this.richTextBox_results.Name = "richTextBox_results";
            this.richTextBox_results.ReadOnly = true;
            this.richTextBox_results.Size = new System.Drawing.Size(289, 149);
            this.richTextBox_results.TabIndex = 4;
            this.richTextBox_results.Text = "";
            // 
            // label_scanned
            // 
            this.label_scanned.AutoSize = true;
            this.label_scanned.Location = new System.Drawing.Point(313, 128);
            this.label_scanned.Name = "label_scanned";
            this.label_scanned.Size = new System.Drawing.Size(55, 15);
            this.label_scanned.TabIndex = 5;
            this.label_scanned.Text = "Scanned:";
            // 
            // label_scoresCount
            // 
            this.label_scoresCount.AutoSize = true;
            this.label_scoresCount.Location = new System.Drawing.Point(18, 401);
            this.label_scoresCount.Name = "label_scoresCount";
            this.label_scoresCount.Size = new System.Drawing.Size(43, 15);
            this.label_scoresCount.TabIndex = 5;
            this.label_scoresCount.Text = "Count:";
            // 
            // richTextBox_scores
            // 
            this.richTextBox_scores.Location = new System.Drawing.Point(18, 94);
            this.richTextBox_scores.Name = "richTextBox_scores";
            this.richTextBox_scores.ReadOnly = true;
            this.richTextBox_scores.Size = new System.Drawing.Size(289, 149);
            this.richTextBox_scores.TabIndex = 4;
            this.richTextBox_scores.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stop at (x) results";
            // 
            // numericUpDown_stopAt
            // 
            this.numericUpDown_stopAt.Location = new System.Drawing.Point(413, 22);
            this.numericUpDown_stopAt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stopAt.Name = "numericUpDown_stopAt";
            this.numericUpDown_stopAt.Size = new System.Drawing.Size(52, 23);
            this.numericUpDown_stopAt.TabIndex = 6;
            this.numericUpDown_stopAt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MAL Heatmap Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopAt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_usernames;
        private System.Windows.Forms.Button button_run2;
        private System.Windows.Forms.TextBox textBox_anime;
        private System.Windows.Forms.TextBox textBox_found;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_scores;
        private System.Windows.Forms.Label label_usernameCount;
        private System.Windows.Forms.Label label_scanned;
        private System.Windows.Forms.Label label_scoresCount;
        private System.Windows.Forms.RichTextBox richTextBox_results;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_stopAt;
        private System.Windows.Forms.Label label3;
    }
}

