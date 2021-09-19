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
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }


        Adminpanel ap = new Adminpanel();
        Admincont ac = new Admincont();
        DataTable dt = new DataTable();
        Newsfeedcont nc = new Newsfeedcont();
       


        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin l = new FormLogin();
            l.Visible = true;
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToShortDateString();

            dt = ap.Alldetails(ac);
            dataGridView1.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ac.StatusId = label1.Text;
            int i = ap.Deletestatus(ac);
            if (i > 0)
            {
                MessageBox.Show("Succesfully Deleted");
                dt = ap.Alldetails(ac);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;


               


                label3.Text = row.Cells["AccountId"].Value.ToString();


                label4.Text = row.Cells["Title"].Value.ToString();

                label5.Text = row.Cells["Catagory"].Value.ToString();


              


                label2.Text = row.Cells["Status"].Value.ToString();


                label1.Text = row.Cells["StatusId"].Value.ToString();


            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            nc.AccountId = label3.Text;
            nc.Status = label2.Text;

            nc.Title = label4.Text;

            nc.FormId = "--------";
            nc.Comment = "no comment";
            nc.StatusId = label1.Text;
            nc.DateTime = DateTime.Now.ToString();

            nc.Catagory = label5.Text;
            int i = ap.approve(nc);
            if (i > 0)
            {
                MessageBox.Show("post approved and released");
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            {
                nc.DateTime = textBox2.Text;

                dt = ap.search(nc);

                dataGridView1.DataSource = dt;
            }

            ac.StatusId = label1.Text;
            int i = ap.Deletestatus(ac);
            if (i > 0)
            {
               
                dt = ap.Alldetails(ac);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
