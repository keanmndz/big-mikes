using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mikes_Accounting_Information_System
{
    public class PayrollClass
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string BasicPay { get; set; }
        public string Allowance { get; set; }
        public string Tax { get; set; }
        public string SSS { get; set; }
        public string PAGIBIG { get; set; }
        public string PhilHealth { get; set; }
        public string GrossPay { get; set; }
        public string NetPay { get; set; }
    }
}
