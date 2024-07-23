//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1DotNetFramework
{
   
    class Program //internal by defauult
    {
      
        static void Main(string[] args)
        {
            System. Console.WriteLine("Hello");
            Product product = new Product();//instance of Product class
                                            // Product p = new();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            //list.Add("hello");//compile time error

            List<int>.Enumerator res1 = list.GetEnumerator();
            string result = "fgfd";
            System.Console.WriteLine( result.Add(20));
          
          
        }
    }

}
