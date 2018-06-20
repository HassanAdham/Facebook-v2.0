namespace Mini_Facebook_V2
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.NeedLbl = new System.Windows.Forms.Label();
            this.SignupLbl = new System.Windows.Forms.Label();
            this.pwTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.pwLbl = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NeedLbl
            // 
            this.NeedLbl.AutoSize = true;
            this.NeedLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NeedLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedLbl.ForeColor = System.Drawing.Color.White;
            this.NeedLbl.Location = new System.Drawing.Point(138, 589);
            this.NeedLbl.Name = "NeedLbl";
            this.NeedLbl.Size = new System.Drawing.Size(84, 16);
            this.NeedLbl.TabIndex = 5;
            this.NeedLbl.Text = "Need Help?";
            // 
            // SignupLbl
            // 
            this.SignupLbl.AutoSize = true;
            this.SignupLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLbl.ForeColor = System.Drawing.Color.White;
            this.SignupLbl.Location = new System.Drawing.Point(106, 556);
            this.SignupLbl.Name = "SignupLbl";
            this.SignupLbl.Size = new System.Drawing.Size(148, 16);
            this.SignupLbl.TabIndex = 4;
            this.SignupLbl.Text = "Sign Up For Facebook";
            this.SignupLbl.Click += new System.EventHandler(this.SignupLbl_Click);
            // 
            // pwTxt
            // 
            this.pwTxt.BackColor = System.Drawing.Color.White;
            this.pwTxt.BorderColorFocused = System.Drawing.Color.Transparent;
            this.pwTxt.BorderColorIdle = System.Drawing.Color.Transparent;
            this.pwTxt.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.pwTxt.BorderThickness = 1;
            this.pwTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.pwTxt.ForeColor = System.Drawing.Color.Black;
            this.pwTxt.isPassword = true;
            this.pwTxt.Location = new System.Drawing.Point(15, 296);
            this.pwTxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(330, 48);
            this.pwTxt.TabIndex = 2;
            this.pwTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pwTxt.OnValueChanged += new System.EventHandler(this.pwTxt_OnValueChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.BorderColorFocused = System.Drawing.Color.Transparent;
            this.usernameTxt.BorderColorIdle = System.Drawing.Color.Transparent;
            this.usernameTxt.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.usernameTxt.BorderThickness = 1;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.Black;
            this.usernameTxt.isPassword = false;
            this.usernameTxt.Location = new System.Drawing.Point(14, 237);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(330, 48);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTxt.OnValueChanged += new System.EventHandler(this.usernameTxt_OnValueChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(15, 354);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(330, 50);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.BackColor = System.Drawing.Color.White;
            this.EmailLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.EmailLbl.Location = new System.Drawing.Point(21, 252);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(133, 19);
            this.EmailLbl.TabIndex = 13;
            this.EmailLbl.Text = "Enter your email";
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.BackColor = System.Drawing.Color.White;
            this.pwLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.pwLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.pwLbl.Location = new System.Drawing.Point(22, 310);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(80, 19);
            this.pwLbl.TabIndex = 13;
            this.pwLbl.Text = "Password";
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.ErrorLbl.Location = new System.Drawing.Point(22, 416);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(305, 40);
            this.ErrorLbl.TabIndex = 14;
            this.ErrorLbl.Text = "Invalid username or password provided.\r\n please try again";
            this.ErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.NeedLbl);
            this.Controls.Add(this.SignupLbl);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NeedLbl;
        private System.Windows.Forms.Label SignupLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox pwTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label pwLbl;
        private System.Windows.Forms.Label ErrorLbl;
    }
}

