using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    internal class AddPartTimeEmp
    {
        public  void EmpFull_Part()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_Rate_Per_Hour = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = (random.Next(3));
            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Full Time Employee...");
                EmpHrs = 12;
            }
            else if (EmpCheck == Is_Part_Time)
            {
                Console.WriteLine("Part Time Employee...");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine(" Employee is Absent...");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("  Employee Total Wage :" + EmpWage);
        }
    }
}

