using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    internal class CheckEmpAvailability
    {
        int Emp_is_present=1;
        public  void CheckEmp()
        {
            
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == 1)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
