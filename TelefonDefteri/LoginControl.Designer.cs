namespace TelefonDefteri
{
    partial class LoginControl
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtUserAdmin = new MetroFramework.Controls.MetroTextBox();
            this.txtPassAdmin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(160, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 58);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserAdmin
            // 
            // 
            // 
            // 
            this.txtUserAdmin.CustomButton.Image = null;
            this.txtUserAdmin.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtUserAdmin.CustomButton.Name = "";
            this.txtUserAdmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserAdmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserAdmin.CustomButton.TabIndex = 1;
            this.txtUserAdmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserAdmin.CustomButton.UseSelectable = true;
            this.txtUserAdmin.CustomButton.Visible = false;
            this.txtUserAdmin.Lines = new string[0];
            this.txtUserAdmin.Location = new System.Drawing.Point(160, 89);
            this.txtUserAdmin.MaxLength = 10;
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.PasswordChar = '\0';
            this.txtUserAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserAdmin.SelectedText = "";
            this.txtUserAdmin.SelectionLength = 0;
            this.txtUserAdmin.SelectionStart = 0;
            this.txtUserAdmin.ShortcutsEnabled = true;
            this.txtUserAdmin.Size = new System.Drawing.Size(165, 23);
            this.txtUserAdmin.TabIndex = 6;
            this.txtUserAdmin.UseSelectable = true;
            this.txtUserAdmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserAdmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAdmin_KeyPress);
            // 
            // txtPassAdmin
            // 
            // 
            // 
            // 
            this.txtPassAdmin.CustomButton.Image = null;
            this.txtPassAdmin.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtPassAdmin.CustomButton.Name = "";
            this.txtPassAdmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassAdmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassAdmin.CustomButton.TabIndex = 1;
            this.txtPassAdmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassAdmin.CustomButton.UseSelectable = true;
            this.txtPassAdmin.CustomButton.Visible = false;
            this.txtPassAdmin.Lines = new string[0];
            this.txtPassAdmin.Location = new System.Drawing.Point(160, 146);
            this.txtPassAdmin.MaxLength = 10;
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '●';
            this.txtPassAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassAdmin.SelectedText = "";
            this.txtPassAdmin.SelectionLength = 0;
            this.txtPassAdmin.SelectionStart = 0;
            this.txtPassAdmin.ShortcutsEnabled = true;
            this.txtPassAdmin.Size = new System.Drawing.Size(165, 23);
            this.txtPassAdmin.TabIndex = 7;
            this.txtPassAdmin.UseSelectable = true;
            this.txtPassAdmin.UseSystemPasswordChar = true;
            this.txtPassAdmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassAdmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassAdmin_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Kullanıcı Adı";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(9, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Şifre         ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginControl
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 304);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtUserAdmin);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginControl";
            this.Text = "Admin Paneli Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginControl_FormClosed);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUserAdmin;
        private MetroFramework.Controls.MetroTextBox txtPassAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}