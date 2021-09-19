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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        Regester r = new Regester();
        DataTable dt = new DataTable();
        Profilecont u = new Profilecont();
        private void labelRegister_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUserID_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin c = new FormLogin();
            this.Visible = false;
            c.Visible = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox2.Text == "" || textBoxUserName.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("please fill all of your information");
            }
            else
            {
                if (textBox2.Text == textBox1.Text)
                {
                    u.Name = textBox4.Text;
                    u.Password = textBox2.Text;
                    u.Aiubid = textBoxUserName.Text;
                    u.Dob = dateTimePicker1.Text;

                    u.Gender = comboBox1.Text;
                    u.Email = textBox5.Text;


                    int i = r.CreateAccount(u);
                    if (i > 0)
                    {
                        MessageBox.Show("Account Created");
                    }
                }
                else { MessageBox.Show("please check your pasword"); }


                u.Email = textBox5.Text;
                u.Aiubid = textBoxUserName.Text;
                u.Password = textBox2.Text;
                dt = r.Profileuid(u);
                if (dt.Rows.Count == 1)
                {


                    label2.Text = dt.Rows[0][0].ToString();
                    

                }
                else
                {
                    MessageBox.Show("INVALID Account No");
                }






            }
        }
    }
}