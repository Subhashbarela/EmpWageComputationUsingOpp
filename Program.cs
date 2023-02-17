using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeDailyWages Obj= new EmployeeDailyWages(20);
            Obj.EmpWage();
            Console.ReadKey();
        }

    }
}
