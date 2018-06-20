using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Facebook_V2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Mainapp s = new Mainapp();
            s.Show();
            this.Hide();
        }

        private void usernameTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                EmailLbl.Visible = true;
            }
            else
            {
                EmailLbl.Visible = false;
            }
        }

        private void pwTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (pwTxt.Text == "")
            {
                pwLbl.Visible = true;
            }
            else
            {
                pwLbl.Visible = false;
            }
        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();
        }
    }
}
