using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestIT
{
    public partial class UserPanel : Form
    {
        public UserPanel(string uid)
        {
            InitializeComponent();
            label2.Text = uid;
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            Comments h = new Comments(label2.Text);
            this.Visible = false;
            h.Visible = true;
        }

        private void ButtonAddPost_Click(object sender, EventArgs e)
        {
            FormNewPost h = new FormNewPost(label2.Text);
            this.Visible = false;
            h.Visible = true;
        }

        private void buttonNewsfeed_Click(object sender, EventArgs e)
        {
            NewsFeed h = new NewsFeed(label2.Text);
            this.Visible = false;
            h.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdatePro h = new FormUpdatePro(label2.Text);
            this.Visible = false;
            h.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin ap = new FormLogin();
            ap.Visible = true;
            this.Visible = false;

        }
    }
}
