using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri
{
    class DepartmentDal
    {
        public static SqlCommand command;
        public static object sayım;
       public static string mesaj;
        public static int sayy;
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=PhoneBook;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }

        public void UpdateDepartment(DepartmentTable departmentTable)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update DepartmentTable set Department=@newDepartment where Department_Id=@department_ıd", _connection);
            command.Parameters.AddWithValue("@newDepartment", AdminUI._txtYeniDepartman);
            command.Parameters.AddWithValue("@department_ıd", departmentTable.Department_Id);
            //command.Parameters.AddWithValue("@department", AdminUI.);
            //   command.Parameters.AddWithValue("@id", AdminDal._id.ToString());
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void AddDepartment(DepartmentTable departmentTable)//departman ekleeme işlemi için yeniitablo oluştumayı denekalıtım almaya çalış
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into DepartmentTable (Department) values (@department)", _connection);
            command.Parameters.AddWithValue("@department", departmentTable.Department);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void DeleteDeparment(int _txtPreview)
        {
            ConnectionControl();
            command = new SqlCommand("Select Count(Name) From PersonelTable where Department_Id=@countDepartment", _connection);
            command.Parameters.AddWithValue("@countDepartment", _txtPreview);
            sayım = command.ExecuteScalar();
            command.Cancel();
            if (Convert.ToInt16(sayım) > 0)
            {

                mesaj = "Bu Departman Altında Çalışan Olduğu İçin Silme İşlemi Gerçekleştirilemiyor";
            }
            else
            {
                sayy = Convert.ToInt32(sayım);
                command = new SqlCommand("Delete From DepartmentTable where Department_Id=@oldDepartment", _connection);
                command.Parameters.AddWithValue("@oldDepartment", _txtPreview);
                command.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public DataTable GetDepartment()
        {
            ConnectionControl();
            SqlCommand command2 = new SqlCommand("Select DISTINCT Department_Id,Department from DepartmentTable Order By Department_Id ASC", _connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(reader2);
            reader2.Close();
            _connection.Close();
            return datatable;
        }

    }
}
