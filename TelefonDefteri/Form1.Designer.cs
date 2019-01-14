namespace TelefonDefteri
{
    partial class frmMainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPublicUILoginn = new MetroFramework.Controls.MetroButton();
            this.btnAdminUILoginn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnPublicUILoginn
            // 
            this.btnPublicUILoginn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPublicUILoginn.Location = new System.Drawing.Point(37, 70);
            this.btnPublicUILoginn.Name = "btnPublicUILoginn";
            this.btnPublicUILoginn.Size = new System.Drawing.Size(183, 127);
            this.btnPublicUILoginn.TabIndex = 2;
            this.btnPublicUILoginn.Text = "PublicUI";
            this.btnPublicUILoginn.UseSelectable = true;
            this.btnPublicUILoginn.Click += new System.EventHandler(this.btnPublicUILoginn_Click);
            // 
            // btnAdminUILoginn
            // 
            this.btnAdminUILoginn.Location = new System.Drawing.Point(256, 70);
            this.btnAdminUILoginn.Name = "btnAdminUILoginn";
            this.btnAdminUILoginn.Size = new System.Drawing.Size(183, 127);
            this.btnAdminUILoginn.TabIndex = 3;
            this.btnAdminUILoginn.Text = "AdminUI";
            this.btnAdminUILoginn.UseSelectable = true;
            this.btnAdminUILoginn.Click += new System.EventHandler(this.btnAdminUILoginn_Click);
            // 
            // frmMainPage
            // 
            this.AcceptButton = this.btnPublicUILoginn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 260);
            this.Controls.Add(this.btnAdminUILoginn);
            this.Controls.Add(this.btnPublicUILoginn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMainPage";
            this.Text = "Telefon Defteri";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnPublicUILoginn;
        private MetroFramework.Controls.MetroButton btnAdminUILoginn;
    }
}

