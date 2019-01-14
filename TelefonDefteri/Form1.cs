using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MetroFramework.Forms;

namespace TelefonDefteri
{
    public partial class frmMainPage : MetroForm  //metro framework
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

     
     

        private void frmMainPage_Load(object sender, EventArgs e)
        {
          
           
        }

        private void btnPublicUILoginn_Click(object sender, EventArgs e)
        {

            PublicUI publicUı = new PublicUI();
            Hide();
            publicUı.ShowDialog();
           
           
        }

        private void btnAdminUILoginn_Click(object sender, EventArgs e)
        {
           
            LoginControl loginControl = new LoginControl();
            Hide();
            loginControl.ShowDialog();
        }
    }
}
