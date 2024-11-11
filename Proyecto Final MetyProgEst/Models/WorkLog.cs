using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_MetyProgEst.Models
{
    internal class WorkLog
    {
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan EntryTime { get; set; }
        public TimeSpan ExitTime { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal OvertimeHours { get; set; }

    }
}
