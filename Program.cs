using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingOpps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWagesUsingSwitchCase Emp = new EmpWagesUsingSwitchCase(20);
            Emp.SwitchCase();
        }
    }
}
