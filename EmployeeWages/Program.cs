using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMP_RATE_PER_HOUR = 20;
            int WORKING_DAYS = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int monthlyWages = 0;
            Random random = new Random(); //function while random is class
            //Computation
            int empCheck = random.Next(0, 3); //Next is method in random class
            switch (empCheck)
            {
                case 1:

                    empHrs = 8;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    monthlyWages = empWage * WORKING_DAYS;
                    Console.WriteLine("Monthly Wages of Full Time Employee is : " + monthlyWages);
                    break;

                case 2:

                    empHrs = 4;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    monthlyWages = empWage * WORKING_DAYS;
                    Console.WriteLine("Monthly Wages of Part Time Employee is : " + monthlyWages);
                    break;


                case 3:

                    empHrs = 0;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    monthlyWages = empWage * WORKING_DAYS;
                    Console.WriteLine("Monthly Wages of Absent Employee is : " + monthlyWages);
                    break;
                default:
                    Console.WriteLine("Invalid selection of Employee Try Again ");
                    break;
                    

            }



        }
    }
}