using System;

namespace Employee
{

    public class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }




        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            //Variables
            int empHrs = 0;

            int totalWorkingDays = 0;


            int totalEmpHrs = 0;

            while (totalWorkingDays < companyEmpWage.numOfWorkingDays && totalEmpHrs <= companyEmpWage.maxHoursPerMonth)
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;
            
        }
    }
    public class CompanyEmpWage
    {
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 20, 2, 10);
            empWageBuilder.computeEmpWage();

        }
    }
}