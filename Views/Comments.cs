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
    public partial class Comments : Form
    {
        public Comments(string uid)
        {
            InitializeComponent();
            label3.Text = uid;
        }

        commentcont ct = new commentcont();
        comment c = new comment();
        DataTable dt = new DataTable();

        private void labelMyAccount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel c = new UserPanel(label3.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            ct.AccountId = label3.Text;
            dt = c.commentdetails(ct);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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

                //row.Cells["FormId"].ReadOnly = true;
                //row.Cells["Status"].ReadOnly = true;
                //row.Cells["StatusId"].ReadOnly = true;






                labelMyAccount.Text = row.Cells["FromId"].Value.ToString();


                label2.Text = row.Cells["Status"].Value.ToString();


                label4.Text = row.Cells["StatusId"].Value.ToString();


            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            if (labelMyAccount.Text == "" || label4.Text == "" || label3.Text == "" || richTextBoxComment.Text == "")
            {
                MessageBox.Show("Value cannot be empty,image and signature cannot be empty,may be name or email address is not in valid format");
            }
            else
            {

                ct.AccountId = label3.Text;
                ct.Status = label2.Text;

                ct.comment = richTextBoxComment.Text;

                ct.FormId = labelMyAccount.Text;
              
                ct.StatusId = label4.Text;

                
                int i = c.Replycomment(ct);
                if (i > 0)
                {
                    MessageBox.Show("Reply Posted");
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
        }
    }
    
}
