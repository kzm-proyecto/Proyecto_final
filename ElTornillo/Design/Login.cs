using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Logic.Login lg = new Logic.Login();
        Form1 f1 = new Form1();

        private void button_accept_Click(object sender, EventArgs e)
        {
            if (lg.Verification(textBox_user.Text) != -1)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_user.Text))
            {
                Application.Exit();
            }
            else
            {
                textBox_user.Text = "";
            }
        }
    }
}
