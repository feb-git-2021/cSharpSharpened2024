using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.HR
{
  public class Employee
    {
        const int minHoursWorked = 1;
        EmployeeType employeeType;
        private double hourlyRate;
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public string Email { get; set; }

        public int NoOfHrsWorked { get; set; }
        public double Wage { get; set; }
        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }
        public DateTime Birthday { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public Employee()
        {

        }
        public Employee(string fname, string lname, string email, DateTime birthdate,double? rate, EmployeeType empType)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Birthday=birthdate;
            HourlyRate = rate ?? 10;
            //employeeType = empType;
            EmployeeType = empType;
        }
        public void PerformWork()
        {
            PerformWork(NoOfHrsWorked);
        }
        public void PerformWork(int noOfHours)
        {
           NoOfHrsWorked += noOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {NoOfHrsWorked} hour(s)!");
        }
        public int CalculateBonus(int bonus)
        {
            if (NoOfHrsWorked > 10)
                bonus *= 2;
            Console.WriteLine($"The employee got bonus of {bonus}");
            return bonus;
        }
        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NoOfHrsWorked > 10)
                bonus *= 2;
            if(bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }
            Console.WriteLine($"The employee got a bonus of {bonus} and the tax deducted is {bonusTax}");
            return bonus;
        }
        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;
            if (EmployeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {FirstName} is a manager");
                wageBeforeTax = NoOfHrsWorked * HourlyRate * 1.25;
            }
            else
            {
                wageBeforeTax = NoOfHrsWorked * HourlyRate;
            }
            double taxAmount = wageBeforeTax * 10;
            Wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NoOfHrsWorked} hour(s) of work");
            if(resetHours)
                NoOfHrsWorked = 0;
            return Wage;

        }
        //public double CalculateWage()
        //{
        //    WageCaluctions wageCalculation = wageCalculation();
        //  double calculateValue= wageCalculation .ComplexWageCalculation();

       // return  calculateValue;
        //}
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
           
        }
        public static void DisplayTaxRate()
        {
           // Console.WriteLine($"The current tax rate is {taxRate}");
        }
        public void DisplayEmplyeeDetails()
        {
            Console.WriteLine($"\nFirst name:\t{FirstName}");
        }


    }
}
