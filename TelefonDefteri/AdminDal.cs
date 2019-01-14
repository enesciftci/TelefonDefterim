using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonDefteri
{
    public class AdminDal
    {
        public static int _id;// giriş yapan kullanıcının id bilgisini tutmak için kullanılır
        public static string _userName = "";//giriş yapan kullanıcının ad bilgisini tutmak için kullanılır
        public static long _password = 0;//giriş yapan kullanıcının şifre bilgisini tutmak için kullanılır

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=PhoneBook;integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }

        public bool LoginControl(string username, long password)//adminUI girişi için kullanıcıdan gelen veriler kontrol edilir true-false döner
        {
            ConnectionControl();
            bool durum ;
            string query = "Select Id,UserName,Password from AdminTable where UserName=@user And Password=@pass";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@pass", password);
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                durum = true;
                _id=dataTable.Rows[0].Field<int>("Id");
                _userName = username;
                _password = password;
            }
            else
            {
                durum = false;
            }
            return durum;
        }
      
        public void UpdatePassword(AdminTable adminTable)//mevcut şifre değişimi için kullanılır
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update AdminTable set Password=@newPassword where Id=@id", _connection);
            command.Parameters.AddWithValue("@newPassword", AdminDal._password);
            command.Parameters.AddWithValue("@id", AdminDal._id.ToString());
            command.ExecuteNonQuery();
            _connection.Close();
        }

      
     
    }
}