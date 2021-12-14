using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random(); //function while random is class
            int empCheck = random.Next(0, 2); //Next is method in random class
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }


        }
    }
}