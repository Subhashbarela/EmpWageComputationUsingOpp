using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    internal class EmpWagesUsingSwitchCase
    {
       
        int Emp_Rate_Per_Hour;
        public EmpWagesUsingSwitchCase(int empRt)
        {
            Emp_Rate_Per_Hour = empRt;
        }
        public  void SwitchCase()
        {
            Console.WriteLine(" Calculate Employee  Wage Using Switch Case :");
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
           
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = (random.Next(3));
            switch (EmpCheck)
            {

                case Is_Full_Time:
                    Console.WriteLine("  Full Time Employee...");
                    EmpHrs = 12;
                    break;

                case Is_Part_Time:

                    Console.WriteLine("  Part Time Employee...");
                    EmpHrs = 8;
                    break;

                default:
                    Console.WriteLine("  Employee is Absent...");
                    EmpHrs = 0;
                    break;
            }

            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine(" Employee  Wage is  :" + EmpWage);


        }
    }
}
