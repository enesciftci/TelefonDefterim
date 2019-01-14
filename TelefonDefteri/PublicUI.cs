using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TelefonDefteri
{
    public partial class PublicUI :MetroForm 
    {
        public PublicUI()
        {
            InitializeComponent();
        }
       PersonelDal personelDal = new PersonelDal();
        PhoneBookEvents PhoneBookEvents = new PhoneBookEvents();
        private void PublicUI_Load(object sender, EventArgs e)
        {
            dgwPublicc.DataSource = personelDal.GetList();//publicUI ekranındaki datagridview için personelDal nesnesinden Getlist fonksiyonu döner
            dgwPublicc.Columns["ManagerStatus"].Visible = false;
            dgwPublicc.Columns["Surname"].Visible = false;
            dgwPublicc.Columns["Department"].Visible = false;
            dgwPublicc.ClearSelection();// verilerin çekildiği anda her hangi bir seçim olmaması için 

        }
     
        private void dgwPublic_SelectionChanged(object sender, EventArgs e)
        {
            

           
        }


        private void dgwPublicc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //detay bilgi gösterimi yapılmakta
            lblNamee.Text = dgwPublicc.CurrentRow.Cells["Name"].Value.ToString();
            lblSurnamee.Text = dgwPublicc.CurrentRow.Cells["Surname"].Value.ToString();
            lblDepartmentt.Text = dgwPublicc.CurrentRow.Cells["Department"].Value.ToString();
            lblTelNumberr.Text = dgwPublicc.CurrentRow.Cells["TelNumber"].Value.ToString();
            lblManager.Text = dgwPublicc.CurrentRow.Cells["ManagerStatus"].Value.ToString();
        }

        private void PublicUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.Show();
            this.Close();
        }
    }
}
