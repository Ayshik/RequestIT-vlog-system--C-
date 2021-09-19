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
    public partial class FormUpdatePro : Form
    {
        public FormUpdatePro(string uid)
        {
            InitializeComponent();
            label2.Text = uid;
        }
        Profilecont pc = new Profilecont();
        Profile p = new Profile();
        DataTable dt = new DataTable();
        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UserPanel c = new UserPanel(label2.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormUpdatePro_Load(object sender, EventArgs e)
        {
            pc.UserId = label2.Text;
            dt = p.Profiledetails(pc);
            if (dt.Rows.Count == 1)
            {
               

                textBox4.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox5.Text = dt.Rows[0][6].ToString();
                textBoxUserName.Text = dt.Rows[0][3].ToString();
                comboBox1.Text = dt.Rows[0][5].ToString();
                dateTimePicker1.Text = dt.Rows[0][4].ToString();
               
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }




        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)

            {



                pc.UserId = label2.Text;
                pc.Name = textBox4.Text;

                pc.Password = textBox2.Text;


                pc.Dob = dateTimePicker1.Text.ToString();

                pc.Email = textBox5.Text;

                pc.Gender = comboBox1.Text;
                pc.Aiubid = textBoxUserName.Text;

                int i = p.UpdateUser(pc);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Updated");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else { MessageBox.Show("Your password didn't match"); }
        }
    }
}
