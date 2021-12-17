using System;

namespace Employee
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static  int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
         
            //Variables
            int empHrs = 0;
            
            int totalWorkingDays = 0;
            
            
            int totalEmpHrs = 0;
 
            while (totalWorkingDays <= numOfWorkingDays && totalEmpHrs < maxHoursPerMonth)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;

                Console.WriteLine("Day#: " + totalWorkingDays + " EMP  hours :" + empHrs);
               
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour; 
            Console.WriteLine("Total emp Wage for company : " + company + " is:" + totalEmpWage);
            return totalEmpWage;



        }
        static void Main(string[] args)
        {
            computeEmpWage("Dmart",20,2,10);
            computeEmpWage("Dmart", 10, 4, 20);
        }
    }
}
