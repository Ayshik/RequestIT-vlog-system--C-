namespace RequestIT
{
    partial class FormNewPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPost));
            this.label1 = new System.Windows.Forms.Label();
            this.panelNfeed = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNewsFeed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.comboBoxCatagory = new System.Windows.Forms.ComboBox();
            this.ButtonPost = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelWantToPostSomething = new System.Windows.Forms.Label();
            this.panelNfeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panelNfeed
            // 
            this.panelNfeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNfeed.BackgroundImage")));
            this.panelNfeed.Controls.Add(this.label2);
            this.panelNfeed.Controls.Add(this.button1);
            this.panelNfeed.Controls.Add(this.buttonNewsFeed);
            this.panelNfeed.Controls.Add(this.textBox1);
            this.panelNfeed.Controls.Add(this.labelPost);
            this.panelNfeed.Controls.Add(this.labelUserID);
            this.panelNfeed.Controls.Add(this.comboBoxCatagory);
            this.panelNfeed.Controls.Add(this.ButtonPost);
            this.panelNfeed.Controls.Add(this.richTextBox1);
            this.panelNfeed.Controls.Add(this.labelWantToPostSomething);
            this.panelNfeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNfeed.Location = new System.Drawing.Point(0, -1);
            this.panelNfeed.Name = "panelNfeed";
            this.panelNfeed.Size = new System.Drawing.Size(876, 569);
            this.panelNfeed.TabIndex = 1;
            this.panelNfeed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNfeed_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "-----------";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.button1.Location = new System.Drawing.Point(10, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.buttonNewsFeed.Location = new System.Drawing.Point(31, 353);
            this.buttonNewsFeed.Name = "buttonNewsFeed";
            this.buttonNewsFeed.Size = new System.Drawing.Size(113, 36);
            this.buttonNewsFeed.TabIndex = 8;
            this.buttonNewsFeed.Text = "Newsfeed";
            this.buttonNewsFeed.UseVisualStyleBackColor = true;
            this.buttonNewsFeed.Click += new System.EventHandler(this.buttonNewsFeed_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 28);
            this.textBox1.TabIndex = 7;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(33, 97);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(71, 27);
            this.labelPost.TabIndex = 6;
            this.labelPost.Text = "Title :";
            this.labelPost.Click += new System.EventHandler(this.labelPost_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(611, 19);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(91, 26);
            this.labelUserID.TabIndex = 5;
            this.labelUserID.Text = "User ID :";
            // 
            // comboBoxCatagory
            // 
            this.comboBoxCatagory.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatagory.ItemHeight = 18;
            this.comboBoxCatagory.Items.AddRange(new object[] {
            "Books",
            "Information",
            "Project Equipment",
            "Lecture Materials"});
            this.comboBoxCatagory.Location = new System.Drawing.Point(635, 97);
            this.comboBoxCatagory.MaxLength = 12;
            this.comboBoxCatagory.Name = "comboBoxCatagory";
            this.comboBoxCatagory.Size = new System.Drawing.Size(119, 26);
            this.comboBoxCatagory.TabIndex = 3;
            this.comboBoxCatagory.Text = "Choose Catagory";
            // 
            // ButtonPost
            // 
            this.ButtonPost.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.ButtonPost.Location = new System.Drawing.Point(660, 361);
            this.ButtonPost.Name = "ButtonPost";
            this.ButtonPost.Size = new System.Drawing.Size(75, 36);
            this.ButtonPost.TabIndex = 2;
            this.ButtonPost.Text = "Post";
            this.ButtonPost.UseVisualStyleBackColor = true;
            this.ButtonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(723, 136);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // labelWantToPostSomething
            // 
            this.labelWantToPostSomething.AutoSize = true;
            this.labelWantToPostSomething.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWantToPostSomething.Location = new System.Drawing.Point(52, 15);
            this.labelWantToPostSomething.Name = "labelWantToPostSomething";
            this.labelWantToPostSomething.Size = new System.Drawing.Size(260, 28);
            this.labelWantToPostSomething.TabIndex = 0;
            this.labelWantToPostSomething.Text = "Want to post something ?!";
            // 
            // FormNewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(875, 565);
            this.Controls.Add(this.panelNfeed);
            this.Controls.Add(this.label1);
            this.Name = "FormNewPost";
            this.Text = "FormNewPost";
            this.Load += new System.EventHandler(this.FormNFeed_Load);
            this.panelNfeed.ResumeLayout(false);
            this.panelNfeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNfeed;
        private System.Windows.Forms.Button ButtonPost;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelWantToPostSomething;
        private System.Windows.Forms.ComboBox comboBoxCatagory;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNewsFeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}