using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ConDotNet8AndCSharp12
{
  
   public static class Interceptors
    {
        [InterceptsLocation("D:\\Trainings-2024\\DotNetSharpened-DAP-4 PM-7PM\\ConDotNet8AndCSharp12\\ConDotNet8AndCSharp12\\Program.cs",line:15,column:19)]
        //[InterceptsLocation("D:\\Trainings-2024\\DotNetSharpened-DAP-4 PM-7PM\\ConDotNet8AndCSharp12\\ConDotNet8AndCSharp12\\Program.cs", line: 19, column: 5)]
        public static void InterceptorDisplay(this Pie ex, string name)
        {
            Console.WriteLine(  $"Interceptor Display : {name}");
        }
    }
}
