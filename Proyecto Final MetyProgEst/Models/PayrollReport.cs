using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_MetyProgEst.Models
{
    internal class PayrollReport
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public DateTime CalculationDate { get; set; }
        public decimal NetSalary { get; set; }

    }
}
