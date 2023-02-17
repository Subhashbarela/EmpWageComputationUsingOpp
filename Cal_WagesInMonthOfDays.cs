using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    internal class Cal_WagesInMonthOfDays
    {
        int Emp_Rate_Per_Hour;
        int WORKING_DAYS;
        public Cal_WagesInMonthOfDays(int EmpRate,int WrkDays) {
            Emp_Rate_Per_Hour = EmpRate;
            WORKING_DAYS = WrkDays;
        }
        public void WagesOFMonth()
        {
            
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
           
            int EmpHrs = 0, EmpWage = 0, Total_Hrs = 0, TotalEmpWages = 0;

            for (int Day = 1; Day <= WORKING_DAYS; Day++)
            {
                Random random = new Random();
                int EmpCheck = (random.Next(3));

                if (EmpCheck == Is_Full_Time)
                {

                    EmpHrs = 12;
                }
                else if (EmpCheck == Is_Part_Time)
                {
                    EmpHrs = 8;
                }
                else
                {
                    EmpHrs = 0;
                }
                EmpWage += Emp_Rate_Per_Hour * EmpHrs;
                TotalEmpWages += EmpWage;
                //Console.WriteLine(" Employee  Wage :" + EmpWage);
            }
            Console.WriteLine(" Employee Total Wage :" + TotalEmpWages);
        }
    }
}
