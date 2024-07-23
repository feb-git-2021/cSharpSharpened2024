// See https://aka.ms/new-console-template for more information
using ConsoleAppDotNetCore;
using System.Collections;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
Student student = new();
int age=22;
string personName = "David";
const decimal interestRate = 0.5m;
//interestRate = interestRate + 2;

string firstName = "Frank";
string lastName = "Smith";


double ratePerHour = 12.34;
int noOfHrsWorked = 160;

double currentWage = ratePerHour * noOfHrsWorked +100;
//if(currentWage > 2000)
//{

//}
//TimeSpan  //represents a period of time

DateTime empStartDate = new DateTime(2023, 02, 28);
DateTime today= DateTime.Today;
DateTime afterTwoYears = today.AddYears(2);


int[] sampleArray = new int[] { 4, 6, 8, 10, 12, 14 };
foreach(int sample in sampleArray)
{
    Console.WriteLine(sample);
}

//int [] nums = new int[4];
//Console.WriteLine("Enter elements into the array");

//for(int i = 0; i < nums.Length; i++)
//{
//    nums[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("The elements of the array are ...");
//foreach (var item in nums)
//{
//    Console.Write(item + ",");
//}
//Student[] students = new Student[] { new Student()}

ArrayList arrs = new ArrayList();

arrs.Add(1);//unboxing
//arrs.Add("hello");

//foreach (var item in arrs)
//{
//    int res = (int)item;
//    Console.WriteLine(res);
//}
Console.WriteLine("---------------------------");
List<string> list1 = new List<string> { "a","b","c" };

//var list = new List<int>() { 66,77,88}.AsReadOnly() ;

var list = new List<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
//var l =list.AsReadOnly();
//l.Add(88);


foreach (var item in list)
{
    Console.WriteLine(item);
}


//list.Add("hello");//compile time error

//List<int>.Enumerator res1=list.GetEnumerator();

//var result = list.GetEnumerator();
//var ans = list1.GetEnumerator();
//while (result.MoveNext() && ans.MoveNext())
//{
//    Console.WriteLine($" {result.Current} and { ans.Current}");
//}

Console.WriteLine("------------------");
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

        // Create a read-only wrapper around the list
        ReadOnlyCollection<string> readOnlyNames = new ReadOnlyCollection<string>(names);

// Now, you can only fetch data from the read-only collection
// Console.WriteLine(readOnlyNames[1]); 
// Prints "Bob"// Uncommenting the line below will throw an exception:

//readOnlyNames.Add("David");


    
