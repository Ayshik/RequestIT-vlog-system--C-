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
    public partial class NewsFeed : Form
    {
        Newsfeed d = new Newsfeed();
        DataTable dt = new DataTable();
        Newsfeedcont nfc = new Newsfeedcont();
       
        public NewsFeed(string uid)
        {
            InitializeComponent();
            label2.Text = uid;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            nfc.Title = textBox1.Text;
            nfc.Catagory = comboBoxCatagory.Text;
            dt = d.Newsfeedsearch(nfc);


            // Text = dt.Rows[0][0].ToString();

            dataGridView1.DataSource = dt;
        }

        private void comboBoxCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || label4.Text == "" || comboBoxCatagory.Text == "" || label1.Text == "" || label4.Text == "" || label3.Text == "" || richTextBoxComment.Text == "")
            {
                MessageBox.Show("Value cannot be empty,image and signature cannot be empty,may be name or email address is not in valid format");
            }
            else
            {

                nfc.AccountId = label4.Text;
                nfc.Status = label1.Text;

                nfc.Title = textBox1.Text;

                nfc.FormId = label2.Text;
                nfc.Comment = richTextBoxComment.Text;
                nfc.StatusId = label3.Text;

                nfc.Catagory = comboBoxCatagory.Text;
                int i = d.Comment(nfc);
                if (i > 0)
                {
                    MessageBox.Show("comment Posted");
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
        }

        private void richTextBoxComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel c = new UserPanel(label2.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelNewsFeed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewsFeed_Load(object sender, EventArgs e)
        {
            dt =d.Newsfeeddetails(nfc);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;
                //var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //var status = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //var fid = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                //var catagory = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                //var title = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                row.Cells["Title"].ReadOnly = true;
                row.Cells["Catagory"].ReadOnly = true;
                row.Cells["AccountId"].ReadOnly = true;
                row.Cells["Status"].ReadOnly = true;
                row.Cells["StatusId"].ReadOnly = true;



                textBox1.Text = row.Cells["Title"].Value.ToString();

                comboBoxCatagory.Text = row.Cells["Catagory"].Value.ToString();

                
                label4.Text = row.Cells["AccountId"].Value.ToString();

                
                label1.Text = row.Cells["Status"].Value.ToString();

                
                label3.Text = row.Cells["StatusId"].Value.ToString();


            }
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            comboBoxCatagory.Text = "";


            label4.Text = "";


            label1.Text = "";


            label3.Text = "";
        }
    }
}
