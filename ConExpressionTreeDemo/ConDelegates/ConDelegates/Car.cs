using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDelegates
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public Car()
        {
                
        }
        public Car(int carId, string make, string name)
        {
            CarId = carId;
            Make = make;
            Name = name;
        }
    }
}
