using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    public class EmployeeDay
    {
        public const int IS_FULL_TIME = 1;
        public const int EMPLOYEE_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS=20;
        public static void CheckEmployeeWorkDays()
        {


            int empHrs = 0;
            int empWage = 0;
            int totalEmpWag = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {

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
                totalEmpWag += empCheck;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWag);
        }
    }
}
