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
    public partial class Mainapp : Form
    {
        public Mainapp()
        {
            InitializeComponent();
        }
        
        private void FeedsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(FeedsBtn.Checked == true)
            {
                FeedsBtn.BackgroundImage = feedsA.Image;
            }
            else
            {
                FeedsBtn.BackgroundImage = feedsNA.Image;
            }
        }
        
        private void FriendsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(FriendsBtn.Checked == true)
            {
                FriendsBtn.BackgroundImage = friendsA.Image;
            }
            else
            {
                FriendsBtn.BackgroundImage = friendsNA.Image;
            }
        }

        private void NotificationBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(NotificationBtn.Checked == true)
            {
                NotificationBtn.BackgroundImage = notiA.Image;
            }
            else
            {
                NotificationBtn.BackgroundImage = notiNA.Image;
            }             
        }

        private void SettingsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(SettingsBtn.Checked == true)
            {
                SettingsBtn.BackgroundImage = settingsA.Image;
            }
            else
            {
                SettingsBtn.BackgroundImage = settingsNA.Image;
            }
        }
    }
}
