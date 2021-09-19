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
    public partial class FormLogin : Form
    {

        login l = new login();
        logincont lc = new logincont();
        DataTable dt = new DataTable();
        Boolean state = false;


        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister ra = new FormRegister();
            ra.Visible = true;
            this.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("TextBox cannot be empty");
            }
            else
            {
                lc.UserId =int.Parse(textBoxUserName.Text);
                lc.Password = textBoxPassword.Text;



                {
                    if (state == false)
                    {
                        dt = l.Loginuser(lc);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            UserPanel c = new UserPanel(textBoxUserName.Text);
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                    if (state == false)
                    {
                        dt = l.Loginadmin(lc);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            FormAdminPanel c = new FormAdminPanel();
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }
                    if (state == false)
                    {
                        MessageBox.Show("Error 69....Invalid id,No ID found in Database");
                    }
                }





            }
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
