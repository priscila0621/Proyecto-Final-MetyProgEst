using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_MetyProgEst.Models
{
    internal class Payroll
    {
        public int EmployeeID { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime CalculationDate { get; set; }
    }
}
