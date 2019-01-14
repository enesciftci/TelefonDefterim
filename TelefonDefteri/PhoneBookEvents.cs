using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonDefteri
{
   public class PhoneBookEvents
    {
      public bool CloseControl(DialogResult result)
        {
           
            if(result==DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public ComboBox DepartmentCombobox(ComboBox comboBox)
        {
          
            if(comboBox.SelectedIndex==1)//Güncelleme
            {
                AdminUI._DepartmentIslemTuru = 0;
            }
            else if(comboBox.SelectedIndex==2)//Ekleme
            {
                AdminUI._DepartmentIslemTuru = 1;
            }
            else if(comboBox.SelectedIndex==3)//Silme
            {
                AdminUI._DepartmentIslemTuru = 2;
            }
            else
            {
                AdminUI._DepartmentIslemTuru = 3;
            }
            return comboBox;
        }
        public ComboBox EmployeesCombobox(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 1)//Güncelleme
            {
                AdminUI._EmployeesIslemTuru = 0;
            }
            else if (comboBox.SelectedIndex == 2)//Silme
            {
                AdminUI._EmployeesIslemTuru = 1;
            }
            else
            {
                AdminUI._EmployeesIslemTuru = 2;
            }
            return comboBox;
        }
    
    }
}
