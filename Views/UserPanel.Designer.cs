namespace RequestIT
{
    partial class UserPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonPost = new System.Windows.Forms.Button();
            this.buttonNewsfeed = new System.Windows.Forms.Button();
            this.ButtonAddPost = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelUserID);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ButtonPost);
            this.panel1.Controls.Add(this.buttonNewsfeed);
            this.panel1.Controls.Add(this.ButtonAddPost);
            this.panel1.Location = new System.Drawing.Point(9, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 574);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "..................";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(647, 30);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(91, 26);
            this.labelUserID.TabIndex = 57;
            this.labelUserID.Text = "User ID :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.button2.Location = new System.Drawing.Point(316, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "          My Information        ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.button1.Location = new System.Drawing.Point(816, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonPost
            // 
            this.ButtonPost.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.ButtonPost.Location = new System.Drawing.Point(348, 294);
            this.ButtonPost.Name = "ButtonPost";
            this.ButtonPost.Size = new System.Drawing.Size(252, 36);
            this.ButtonPost.TabIndex = 5;
            this.ButtonPost.Text = "My Posts and Comments";
            this.ButtonPost.UseVisualStyleBackColor = true;
            this.ButtonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // buttonNewsfeed
            // 
            this.buttonNewsfeed.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.buttonNewsfeed.Location = new System.Drawing.Point(367, 222);
            this.buttonNewsfeed.Name = "buttonNewsfeed";
            this.buttonNewsfeed.Size = new System.Drawing.Size(211, 36);
            this.buttonNewsfeed.TabIndex = 4;
            this.buttonNewsfeed.Text = "Newsfeed";
            this.buttonNewsfeed.UseVisualStyleBackColor = true;
            this.buttonNewsfeed.Click += new System.EventHandler(this.buttonNewsfeed_Click);
            // 
            // ButtonAddPost
            // 
            this.ButtonAddPost.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.ButtonAddPost.Location = new System.Drawing.Point(367, 150);
            this.ButtonAddPost.Name = "ButtonAddPost";
            this.ButtonAddPost.Size = new System.Drawing.Size(211, 36);
            this.ButtonAddPost.TabIndex = 3;
            this.ButtonAddPost.Text = "Add A New Post";
            this.ButtonAddPost.UseVisualStyleBackColor = true;
            this.ButtonAddPost.Click += new System.EventHandler(this.ButtonAddPost_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 586);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonPost;
        private System.Windows.Forms.Button buttonNewsfeed;
        private System.Windows.Forms.Button ButtonAddPost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserID;
    }
}