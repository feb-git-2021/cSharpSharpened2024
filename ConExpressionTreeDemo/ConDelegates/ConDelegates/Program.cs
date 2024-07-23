// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

namespace ConDelegates
{
   // public delegate void WriteMessage(string message);  

    internal class Program
    {
        #region CommentedCode
        //public static bool WriteMessageFunction(string message)
        //{
        //    Console.WriteLine(  message );
        //    return true;
        //}

        //public static bool WriteTimelyFunction(string message)
        //{
        //    Console.WriteLine($"{message} {DateTime.Now}");
        //    return true;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region CommentedMainmethodCode

            // WriteMessage func = WriteMessageFunction;
            //func("Hello delegdates!!!");
            //Console.WriteLine(  "Enter a string input.....");
            //var userInput= Console.ReadLine();

            //Func<string,bool> func;

            //if (userInput == "1")
            //{
            //    //func = WriteTimelyFunction;
            //    func = message =>
            //    {
            //        Console.WriteLine($"{message} {DateTime.Now}");
            //        return true;
            //    };
            //}
            //else
            //{
            //    //  func= WriteMessageFunction;
            //    func = message =>
            //    {
            //        Console.WriteLine(message);
            //        return true;
            //    };
            //}

            ////bool v = func("Hello World");
            //var result = ExecuteMethod(func);


            //var cars = new List<Car>();
            //cars.Add (new Car(1, "Tata", "Electric Nano"));
            //cars.Add(new Car(4, "Tata", "Harrier"));
            //cars.Add(new Car(2, "Kia", "High end with sun roof"));

            //cars.Add(new Car(3, "Hyundai", "Electric Car"));

            //Func<Car,bool> myCar = Car => Car.Make == "Tata";

            //var myFavCar = cars.Where(myCar);
            //Console.WriteLine(  "---------------------");

            //// var myFavCar = cars.Where(c => c.Make == "Tata");

            //IEnumerable<Car> mycars = Enumerable.Where<Car>(cars, car => car.Name == car.Name);

            //foreach (var fav in mycars)
            //{
            //    Console.WriteLine(fav.Name);

            //}
            #endregion

            var xExpression= Expression.Parameter(typeof(int), "x");
            // var yExpression = Expression.Parameter(typeof(int), "y");
            var constantExpression= Expression.Constant(12);
            var greaterThan = Expression.GreaterThan(xExpression, constantExpression);

            var constant4Expression = Expression.Constant(4);
            var lessThan =Expression.LessThan(xExpression, constant4Expression);


           var or = Expression.Or(greaterThan, lessThan);


            var expr = Expression.Lambda<Func<int, bool> > (or, false, new List<ParameterExpression> { xExpression, });
            var func=expr.Compile();
            Console.WriteLine(func(2));





            var expr1 =Expression.Lambda<Func<int,bool>>(or,false,new List<ParameterExpression> { xExpression });

            var func1 = expr.Compile();

            Console.WriteLine( func(2));
            //var lessThan = Expression.LessThan(xExpression, constantExpression);


        }
        private static bool ExecuteMethod(Func<string,bool> func)
        {
            return func("Hello world!!");
        }
    }
}
