using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    public class SolvingSwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int EMPLOYEE_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 2;
        public static void CheckEmployeeWorkHours()
        {


            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;



            }


            empWage = empHrs * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
