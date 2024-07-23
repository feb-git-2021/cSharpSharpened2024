// See https://aka.ms/new-console-template for more information
using EmployeeApp.HR;

Console.WriteLine("Hello, World!");

Employee david = new Employee("David","Smith","david@zensar.com",new DateTime(1992,1,20),3,EmployeeType.Developer);
Console.Write("How many hours do we need to register for david?");
int numberOfHours = 0;
string input = Console.ReadLine();
//numberOfHours = Convert.ToInt32(input);//OR  
numberOfHours= int.Parse(input);

david.DisplayEmplyeeDetails();
david.PerformWork();
david.PerformWork(numberOfHours);
Console.ReadLine();
