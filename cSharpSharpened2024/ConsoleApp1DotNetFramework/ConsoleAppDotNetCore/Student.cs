using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetCore
{
    
    internal class Student
    {
        readonly string city="hello";
        readonly string name;

        public Student()
        {
            name = "dsfd";
        }
        public int Id { get; set; }
        public string? StudName { get; set; }

        //public void ShowStudent()
        //{
        //    name = "david";
        //}
    }
}
