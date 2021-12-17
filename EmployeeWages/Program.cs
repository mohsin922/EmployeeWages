using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int WORKING_DAYS_IN_MONTH = 20;
            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            
 
            for (int day = 0; day < WORKING_DAYS_IN_MONTH; day++)
            {
                Random random = new Random(); //function while random is class
                int empCheck = random.Next(0, 3); //Next is method in random class
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;

                }
                else if (empCheck == IS_PART_TIME)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Wage : " + totalEmpWage);



        }
    }
}
