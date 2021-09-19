using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RequestIT.Controllers;
using RequestIT.Models;

namespace RequestIT
{
    public partial class FormNewPost : Form
    {
        public FormNewPost(string uid)
        {
            InitializeComponent();
            label2.Text = uid;
        }
        Newpost l = new Newpost();
        Newpostcont u = new Newpostcont();
        DataTable dt = new DataTable();
        private void FormNFeed_Load(object sender, EventArgs e)
        {

        }

        private void labelPost_Click(object sender, EventArgs e)
        {

        }

        private void panelNfeed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text == "" || comboBoxCatagory.Text == "")
            {
                MessageBox.Show("Value cannot be empty,image and signature cannot be empty,may be name or email address is not in valid format");
            }
            else
            {
                
                u.AccountId = label2.Text;
                u.Status = richTextBox1.Text;
                
                u.Title = textBox1.Text;
               
                u.Check = "Waiting";
               
                u.Catagory = comboBoxCatagory.Text;
                int i = l.Newpostentry(u);
                if (i > 0)
                {
                    MessageBox.Show("Post Created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
               

            }
        }

        private void buttonNewsFeed_Click(object sender, EventArgs e)
        {
            UserPanel c = new UserPanel(label2.Text);
            this.Visible = false;
            c.Visible = true;
        }
    }
}
