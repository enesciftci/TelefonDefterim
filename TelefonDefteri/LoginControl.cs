using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TelefonDefteri
{
    public partial class LoginControl : MetroForm
    {
        public LoginControl()
        {
            InitializeComponent();
        }
       
        AdminDal adminDal = new AdminDal();
      
        private void txtFocus()
        {
            txtUserAdmin.Focus();
        } 
        private void LoginControl_Load(object sender, EventArgs e)
        {
            txtFocus();  
        }

        private void btnLogin_Click(object sender, EventArgs e)// admin panel giriş kontrolü
        {
           
            if (!string.IsNullOrEmpty(txtUserAdmin.Text) && !string.IsNullOrEmpty(txtPassAdmin.Text))
            {
                if (adminDal.LoginControl(txtUserAdmin.Text, long.Parse(txtPassAdmin.Text)) == true)//adminDal nesnesinden gelen sonuca göre işlenir
                {
                   ActiveForm.Hide();
                  AdminUI adminUı=new AdminUI();
                    adminUı.Show();


                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserAdmin.Clear();
                    txtPassAdmin.Clear();
                    txtFocus();
                }
            }
            else
            {
               
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtUserAdmin, "Lütfen Boş Alan Bırakmayın");
                errorProvider.SetError(txtPassAdmin, "Lütfen Boş Alan Bırakmayın");
            }
        }

        private void LoginControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainPage frmMainPage = new frmMainPage();
            this.Close();
            frmMainPage.Show();
        }

        private void txtUserAdmin_KeyPress(object sender, KeyPressEventArgs e)//kullanıcı adı için sadece harf girişi için kullanılır
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtPassAdmin_KeyPress(object sender, KeyPressEventArgs e)//kullanıcı şifresi için sadece rakan girişi için kullanılır
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
