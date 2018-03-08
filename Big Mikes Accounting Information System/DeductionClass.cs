using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mikes_Accounting_Information_System
{
    public class DeductionClass
    {
        public int Id { get; set; } 
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string Reason { get; set; }
        public string AmountDeducted { get; set; }
    }
}
