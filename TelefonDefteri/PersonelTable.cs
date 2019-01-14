using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri
{
 public class PersonelTable
    {
        public int Personel_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TelNumber { get; set; }
        public string ManagerName { get; set; }
        public int Department_Id { get; set; }
        public bool YetkiDurumu { get; set; }
    }
}
