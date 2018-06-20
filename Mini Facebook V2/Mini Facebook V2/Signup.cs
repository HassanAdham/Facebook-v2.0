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
    public partial class Signup : Form
    {
        public Signup()
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

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void fnTxt_OnValueChanged(object sender, EventArgs e)
        {
            if(fnTxt.Text == "")
            {
                FirstnameLbl.Visible = true;
            }
            else
            {
                FirstnameLbl.Visible = false;
            }
        }

        private void lnTxt_OnValueChanged(object sender, EventArgs e)
        {
            if(lnTxt.Text == "")
            {
                LastnameLbl.Visible = true;
            }
            else
            {
                LastnameLbl.Visible = false;
            }
        }

        private void mailTxt_OnValueChanged(object sender, EventArgs e)
        {
            if(mailTxt.Text == "")
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
            if(pwTxt.Text == "")
            {
                pwLbl.Visible = true;
                pwImg.Visible = false;
            }
            else
            {
                pwLbl.Visible = false;
                if (repwTxt.Text != "")
                {
                    if (repwTxt.Text == pwTxt.Text)
                    {
                        pwImg.Visible = true;
                        pwImg.Image = TickImg.Image;
                    }
                    else
                    {
                        pwImg.Visible = true;
                        pwImg.Image = WrongImg.Image;
                    }
                }
            }
        }

        private void repwTxt_OnValueChanged(object sender, EventArgs e)
        {
            if(repwTxt.Text == "")
            {
                ConfirmPwLbl.Visible = true;
                pwImg.Visible = false;
            }
            else
            {
                ConfirmPwLbl.Visible = false;
                if (repwTxt.Text == pwTxt.Text)
                {
                    pwImg.Visible = true;
                    pwImg.Image = TickImg.Image;
                }
                else
                {
                    pwImg.Visible = true;
                    pwImg.Image = WrongImg.Image;
                }            
            }
        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            Login s = new Login();
            s.Show();
            this.Close();
        }
    }
}
