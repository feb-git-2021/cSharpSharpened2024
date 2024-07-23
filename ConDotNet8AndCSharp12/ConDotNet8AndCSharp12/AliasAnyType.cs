using Point = (int x, int y);
using StringList = System.Collections.Generic.List<string>;
using Values = int[];
using Person = (string fname, string lname);
using IsMember = bool;

namespace ConDotNet8AndCSharp12
{
    public class AliasAnyType
    {
      public  void Draw(Point point)
        {
            Console.WriteLine( $"{point.x} and {point.y}" );
        }
        void LoopingStringValues(StringList list)
        {
            foreach(string str in list)
            {
                Console.WriteLine( str );
            }
        }
        void LoopOverValues(Values values)
        {
            foreach (var item in values)
            {
                Console.WriteLine( item);
            }
        }
        void DisplayPerson(Person person,IsMember isMember)
        {
            Console.WriteLine($" {person.fname} {person.lname}; Member : {isMember}");
        }
       
        
    }
    
}

