using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random(); //function while random is class
            //Computation
            int empCheck = random.Next(0, 3); //Next is method in random class
            switch (empCheck)
            {
                case 1:

                    empHrs = 8;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    Console.WriteLine("Emp Wage of Full time Employee is : " + empWage);
                    break;

                case 2:

                    empHrs = 4;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    Console.WriteLine("Emp Wage of Part time Employee is : " + empWage);
                    break;


                case 3:

                    empHrs = 0;
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    Console.WriteLine("Emp Wage of Absent Employee is : " + empWage);
                    break;
                default:
                    Console.WriteLine("Invalid selection of Employee Try Again ");
                    break;
                    

            }



        }
    }
}