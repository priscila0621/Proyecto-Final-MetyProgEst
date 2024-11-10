using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_MetyProgEst.Models
{
    internal class Deduction
    {
        public int EmployeeID { get; set; }
        public string DeductionType { get; set; }
        public decimal Amount { get; set; }
    }
}
