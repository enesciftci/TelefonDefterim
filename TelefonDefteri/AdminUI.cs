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
    public partial class AdminUI : MetroForm
    {
        public AdminUI()
        {
            InitializeComponent();
        }
        PersonelDal personelDal = new PersonelDal();
        public static AdminDal adminDal = new AdminDal();
        DepartmentDal departmentDal = new DepartmentDal();
        public static PhoneBookEvents PhoneBookEvents = new PhoneBookEvents();
        public static int _DepartmentIslemTuru;
        public static int _EmployeesIslemTuru;
        public static string _txtYeniDepartman;
        public static string _txtEskiDepartman;
        private void DepartmentLoader()
        {
            PersonelDal personelDal = new PersonelDal();
            dgwDepartmentSettings.DataSource = departmentDal.GetDepartment();
        }
        private void GetEmployeesComboboxSource()
        {
            cmbPersonelPosition.DataSource = departmentDal.GetDepartment();

            cmbPersonelPosition.DisplayMember = "Department";
            cmbPersonelPosition.ValueMember = "Department_Id";
            cmbPersonelStatus.DataSource = personelDal.GetPersonelManager();
            cmbPersonelStatus.DisplayMember = "AdSoyad";
        }
        private void EmployeesLoader()
        {
            PersonelDal personelDal = new PersonelDal();
            dgwEmployeess.DataSource = personelDal.GetList();
        }
      private void GetPersonelComboboxSource()
        {
            cmbDepartment.DataSource = departmentDal.GetDepartment();
            cmbDepartment.DisplayMember = "Department";
            cmbDepartment.ValueMember = "Department_Id";
            cmbPersonelManager.DataSource = personelDal.GetPersonelManager();
            cmbPersonelManager.DisplayMember = "AdSoyad";
        }
        public void AdminUI_Load(object sender, EventArgs e)
        {
          
            txtAdminInfo.Text = AdminDal._userName;
            metroTabControl1.SelectedIndex =-1;
            cmbEmployeesEventsChoose.SelectedIndex = 0;
            cmbDepartmanEventsChoose.SelectedIndex = 0;
            //  cmbPositions.ValueMember="Id"
        }


        private void btnDepartmanEvents_Click(object sender, EventArgs e)
        {
            //cmbDepartmanEventsChoose.SelectedIndex = 0;

            DepartmentLoader();
        }


        private void cmbDepartmanEventsChoose_TextChanged(object sender, EventArgs e)
        {
            PhoneBookEvents.DepartmentCombobox(cmbDepartmanEventsChoose);

            if (_DepartmentIslemTuru == 0)
            {
                btnDepartmentChooser.Text = "Departmanı Güncelle";
                txtPreview.Visible = true;
            }
            else if (_DepartmentIslemTuru == 1)
            {
                btnDepartmentChooser.Text = "Departman Ekle";

                txtPreview.Visible = false;
            }
            else if (_DepartmentIslemTuru == 2)
            {
                btnDepartmentChooser.Text = "Departmanı Sil";
                txtDepartmentChooser.Visible = false;
                txtPreview.Visible = true;
            }
            else
            {
                btnDepartmentChooser.Text = "İşlem Seçiniz";
            }
        }

      
        private void txtPreview_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbEmployeesEventsChoose_TextChanged(object sender, EventArgs e)
        {
            PhoneBookEvents.EmployeesCombobox(cmbEmployeesEventsChoose);
            if (_EmployeesIslemTuru == 0)
            {
                btnPersonelChange.Text = "Çalışanı Güncelle";
            }
            else if (_EmployeesIslemTuru == 1)
            {
                btnPersonelChange.Text = "Çalışanı Sil";
                txtPreview.Visible = false;
            }
            else
            {
                btnDepartmentChooser.Text = "İşlem Seçiniz";
            }
        }

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
           // GetPersonelComboboxSource();
         DialogResult result=MessageBox.Show("Bilgilerini Girdiğiniz Personel Kayıt Edilecek. Emin Misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (personelDal.PersonelControl(txtNameInput.Text, txtSurnameInput.Text, txtTelNumberInput.Text) == true)
                {
                    // if(cmbStatus.Text=="Genel")
                    personelDal.AddPersonel(new PersonelTable
                    {
                        Name = txtNameInput.Text,
                        Surname = txtSurnameInput.Text,
                        TelNumber = Convert.ToInt64(txtTelNumberInput.Text),
                        ManagerName = cmbPersonelManager.Text,
                        Department_Id = (int)cmbDepartment.SelectedValue,//id i aldır
                    });

                    MessageBox.Show("Personel Eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameInput.Clear();
                    txtSurnameInput.Clear();
                    txtTelNumberInput.Clear();
                    GetPersonelComboboxSource();
                }
                else
                {
                    MessageBox.Show("Ad,Soyad ve Telefon Zorunlu Alanlardır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dgwEmployeess_Click(object sender, EventArgs e)
        {
            txtPersonelName.Text = dgwEmployeess.CurrentRow.Cells["Name"].Value.ToString();
            txtPersonelSurname.Text = dgwEmployeess.CurrentRow.Cells["Surname"].Value.ToString();
            txtPersonelTel.Text = dgwEmployeess.CurrentRow.Cells["TelNumber"].Value.ToString();

        }

        private void TabEmployeesEvents_Click(object sender, EventArgs e)
        {

          
        }

        private void TabAddPersonel_Click(object sender, EventArgs e)
        {
         //   GetPersonelComboboxSource();
        }

        private void TabDepartmentEvents_Click(object sender, EventArgs e)
        {
            DepartmentLoader();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroTabControl1.SelectedIndex==0)
            {
                dgwEmployeess.DataSource = personelDal.GetList();
                EmployeesLoader();
                dgwEmployeess.Columns["Personel_Id"].Visible = false;
                GetEmployeesComboboxSource();
            }
            if (metroTabControl1.SelectedIndex==1)
            {
                GetPersonelComboboxSource();
            }
            if(metroTabControl1.SelectedIndex==2)
            {
                DepartmentLoader();
            }
        }

      

        private void dgwDepartmentSettings_Click(object sender, EventArgs e)
        {
            txtPreview.Text = dgwDepartmentSettings.CurrentRow.Cells["Department"].Value.ToString();
        }
        private void btnDepartmentChooser_Click(object sender,EventArgs e)
        {
      
            
            ///////////////////departman işlemleri
            _txtYeniDepartman = txtDepartmentChooser.Text;
            _txtEskiDepartman = txtPreview.Text;
            if (cmbDepartmanEventsChoose.Text == "")
            {
                cmbDepartmanEventsChoose.SelectedIndex = 0;
            }
            else
            {
                if (txtDepartmentChooser.Text != null && _DepartmentIslemTuru == 0)//güncelleme
                {
                    DepartmentTable departmentTable = new DepartmentTable
                    {
                        Department_Id = (int)dgwDepartmentSettings.CurrentRow.Cells["Department_Id"].Value,
                    };
                    departmentDal.UpdateDepartment(departmentTable);
                }
                else if (txtDepartmentChooser.Text != null && _DepartmentIslemTuru == 1)//ekleme
                {
                    DepartmentTable departmentTable = new DepartmentTable
                    {
                        Department = txtDepartmentChooser.Text,
                    };
                    departmentDal.AddDepartment(departmentTable);
                }
                else if (txtDepartmentChooser.Text != null && _DepartmentIslemTuru == 2)//Silme
                {
                    
                    int deleteDepartment = Convert.ToInt32(dgwDepartmentSettings.CurrentRow.Cells["Department_Id"].Value);
                    departmentDal.DeleteDeparment(deleteDepartment);
                    if (Convert.ToInt32(DepartmentDal.sayım) > 0)
                    {
                        MessageBox.Show(DepartmentDal.mesaj.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Departman Silindi");
                    }

                }
                else
                {
                    cmbDepartmanEventsChoose.SelectedIndex = 0;
                }


                txtPreview.Clear();
                txtDepartmentChooser.Clear();
                DepartmentLoader();
            }
        }

        private void btnPersonelChange_Click(object sender, EventArgs e)
        {
            ///////////çalışan işlemleri
            
            if (_EmployeesIslemTuru == 0)//Güncelleme
            {

                PersonelTable personelTable = new PersonelTable
                {
                    Personel_Id = (int)dgwEmployeess.CurrentRow.Cells["Personel_Id"].Value,
                    Name = txtPersonelName.Text,//ıd i aldır
                    Surname = txtPersonelSurname.Text,
                    TelNumber = long.Parse(txtPersonelTel.Text),
                    Department_Id = (int)cmbPersonelPosition.SelectedValue,
                    ManagerName = cmbPersonelStatus.Text,
                };
                personelDal.UpdatePersonel(personelTable);
                MessageBox.Show("Personel Güncellendi");

            }
            else if (_EmployeesIslemTuru == 1)//Silme
            {
                
                
                // personelDal.DeletePersonel(deletePersonel);
                int deletePersonel = Convert.ToInt32(dgwEmployeess.CurrentRow.Cells["Personel_Id"].Value);
                string employeesName = dgwEmployeess.CurrentRow.Cells["Name"].Value.ToString();
                string employeesSurname = dgwEmployeess.CurrentRow.Cells["Surname"].Value.ToString();

                string managerStatusName = dgwEmployeess.CurrentRow.Cells["ManagerStatus"].Value.ToString();
                string employeesNameSurname = employeesName + " " + employeesSurname;

                if (personelDal.ManagerController(employeesNameSurname) == true)
                {
                    MessageBox.Show("Kullanıcı Yönetici", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonelTable personelTable = new PersonelTable
                    {
                        Personel_Id = deletePersonel,
                    };
                    personelDal.DeletePersonel(personelTable);
                    MessageBox.Show("Kullanıcı silindi");
                }

            }
            else if(_EmployeesIslemTuru==2)
            {
                cmbEmployeesEventsChoose.SelectedIndex = 0;
            }
            else
            {
                cmbEmployeesEventsChoose.SelectedIndex = 0;
            }
            EmployeesLoader();
        }

        private void lblChangePass_Click(object sender, EventArgs e)
        {
            updatePass:
            string password = Interaction.InputBox("Şifreyi Doğrulayın", "Şifre İşlemleri");
            AdminDal adminDal = new AdminDal();

            if (password == AdminDal._password.ToString() && password.Length > 0)
            {
                string passwordNew = Interaction.InputBox("Yeni Şifreyi Girin");
                if (passwordNew == "")
                {
                    goto updatePass;
                }
                else
                {
                    AdminDal._password = int.Parse(passwordNew);
                    AdminTable adminTable = new AdminTable
                    {
                        Password = Convert.ToInt64(AdminDal._password)

                    };

                    adminDal.UpdatePassword(adminTable);
                    //  MessageBox.Show(adminTable.Password.ToString());
                }
            }

            else if (password != AdminDal._password.ToString() && password.Length > 0)
            {
                password = "";
                MessageBox.Show("Mevcut Şifre Yanlış Girildi...");
                goto updatePass;
            }
         

        }

        private void cmbEmployeesEventsChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhoneBookEvents.EmployeesCombobox(cmbEmployeesEventsChoose);
            if(_EmployeesIslemTuru==0)
            {
                btnPersonelChange.Text = "Güncelleme";
                cmbPersonelPosition.Visible = true;
                cmbPersonelStatus.Visible = true ;
                metroLabel6.Visible = true;
                metroLabel7.Visible = true;
            }
            else if(_EmployeesIslemTuru==1)
            {
                btnPersonelChange.Text = "Silme";
                cmbPersonelPosition.Visible = false;
                cmbPersonelStatus.Visible = false;
                metroLabel6.Visible = false;
                metroLabel7.Visible = false;
            }
            else
            {
                btnPersonelChange.Text = "İşlem Seçiniz";
            }
        }

        private void cmbDepartmanEventsChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhoneBookEvents.DepartmentCombobox(cmbDepartmanEventsChoose);
            if (_DepartmentIslemTuru == 0)
            {
                btnDepartmentChooser.Text = "Güncelleme";
                txtDepartmentChooser.Visible = true;
                txtPreview.Visible = true;
            }
            else if (_DepartmentIslemTuru == 1)
            {
                btnDepartmentChooser.Text = "Ekleme";
                txtPreview.Visible = false;
                txtDepartmentChooser.Visible = true;
            }
            else if(_DepartmentIslemTuru==2)
            {
                btnDepartmentChooser.Text = "Silme";
                txtDepartmentChooser.Visible = false;
                txtPreview.Visible = true;
            }
            else
            {
                btnPersonelChange.Text = "İşlem Seçiniz";
            }
        }

        private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (PhoneBookEvents.CloseControl(result) == false)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }
    }
}
