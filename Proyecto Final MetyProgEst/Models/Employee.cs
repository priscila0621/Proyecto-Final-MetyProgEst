using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_MetyProgEst.Models
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal BaseSalary { get; set; }
        public DateTime HireDate { get; set; }
    }
}
