using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDotNet8AndCSharp12
{
    public class Pie(int id,string name, double price,IEnumerable<string> ingredients)
    {
        
        public Pie(int id, string name,double price) : this(id, name, price, Enumerable.Empty<string>()) { }

        public int Id=>id;
        
        public string Name { get; set; }=name;
       
        public double Price { get; set; } = Math.Round(price, 2);

        public void DisplayIngredients()
        {
            foreach (var item in ingredients)
            {
                Console.WriteLine(  item);
            }
        }
        

        
    }
   
}
