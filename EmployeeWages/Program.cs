using System;

namespace Employee
{

    public class EmpWageBuilderObject
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }




        public void computeEmpWage()
        {

            //Variables
            int empHrs = 0;

            int totalWorkingDays = 0;


            int totalEmpHrs = 0;

            while (totalWorkingDays <= this.numOfWorkingDays && totalEmpHrs <= this.maxHoursPerMonth)
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
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total emp Wage for company : " + company + " is:" + totalEmpWage);
        }
        public string toString()
        {
            return "Total emp Wage for company : " + this.company + " is:" + this.totalEmpWage;
        }




    }
    class program
    {

        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 20, 2, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());


        }
    }
}