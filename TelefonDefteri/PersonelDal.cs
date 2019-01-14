using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri
{
   public class PersonelDal
    {
      SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=PhoneBook;integrated security=true");
        DataTable datatable = new DataTable();
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
      /*  public List<PersonelTable> GetDetail()
        {
         
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select* From PersonelTable", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<PersonelTable>personels=new List<PersonelTable>();
            while (reader.Read())
            {
                PersonelTable personel = new PersonelTable
                {
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    TelNumber = Convert.ToInt64(reader["TelNumber"]),
                   ManagerStatus = reader["ManagerStatus"].ToString()
                  
                };

                personels.Add(personel);
            }
            reader.Close();
           _connection.Close();
           return personels;
        }*/

        public DataTable GetList()
        {
          ConnectionControl();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select DISTINCT Personel_Id,Name,Surname,TelNumber,ManagerStatus,Department From PersonelTable pt inner join DepartmentTable dt on pt.Department_Id=dt.Department_Id where pt.Personel_Id>0", _connection);
            /* SqlCommand command=new SqlCommand("Select * From PersonelTable",_connection);
             SqlDataReader reader = command.ExecuteReader();*/
            sqlDataAdapter.Fill(datatable);
            
          /*  datatable.Columns[0].ColumnMapping = MappingType.Hidden;
            datatable.Columns[2].ColumnMapping = MappingType.Hidden;
            datatable.Columns[4].ColumnMapping = MappingType.Hidden;
            datatable.Columns[5].ColumnMapping = MappingType.Hidden;*/
             
          
           // reader.Close();
            _connection.Close();
            return datatable;
        }
        public void UpdatePersonel(PersonelTable personel)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update PersonelTable set Name=@name,Surname=@surname,TelNumber=@telnumber,ManagerStatus=@managerStatus,Department_Id=@department_ıd where Personel_Id=@ıd", _connection);
            command.Parameters.AddWithValue("@name", personel.Name);
            command.Parameters.AddWithValue("@surname", personel.Surname);
            command.Parameters.AddWithValue("@telnumber", personel.TelNumber);
            command.Parameters.AddWithValue("@managerStatus", personel.ManagerName);
            command.Parameters.AddWithValue("@department_ıd", personel.Department_Id);
            command.Parameters.AddWithValue("@ıd", personel.Personel_Id);
            command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
        }
        public void AddPersonel(PersonelTable personel)//departman olayını ayarla
        {
            ConnectionControl();
            SqlCommand command=new SqlCommand("Insert into PersonelTable values(@name,@surname,@telnumber,@status,@department)",_connection);
            command.Parameters.AddWithValue("@name", personel.Name);
            command.Parameters.AddWithValue("@surname", personel.Surname);
            command.Parameters.AddWithValue("@telnumber", personel.TelNumber);
            command.Parameters.AddWithValue("@status", personel.ManagerName);
            command.Parameters.AddWithValue("@department", personel.Department_Id);
            command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();

        }
        public void DeletePersonel(PersonelTable personel)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete From PersonelTable where Personel_Id=@personel_ıd",_connection);
            command.Parameters.AddWithValue("@personel_ıd",personel.Personel_Id);
            command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
        }
        public bool ManagerController(string managerController)
        {
            DataView dataView = new DataView(datatable);
            dataView.RowFilter = "ManagerStatus='"+ managerController +"'";
            if(dataView.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetPersonelManager()//
        {
            DataTable datatable = new DataTable();
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select Name+' '+Surname as AdSoyad from PersonelTable", _connection);
            SqlDataReader reader = command.ExecuteReader();
            datatable.Load(reader);

            reader.Close();
            _connection.Close();

            return datatable;
        }
        public bool PersonelControl(string _name,string _surname,string _telNumber)
        {
            bool _durum = false;
            if (_name==""||_surname==""||_telNumber=="")
            {
                _durum = false;
            }
            else
            {
                _durum = true;
            }
            return _durum;
        }
    }
}
