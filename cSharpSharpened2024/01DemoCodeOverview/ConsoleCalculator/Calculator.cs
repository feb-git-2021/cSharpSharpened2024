namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
       // ArgumentNullException.ThrowIfNull(operation);
        string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
        if (nonNullOperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("....Logging.......");


                // throw;
                // throw new ArithmeticException("An error occured during calculation.", ex);
                throw new CalculationException(ex);
            }
            return Divide(number1, number2);
        }
        else
        {
            //throw new ArgumentOutOfRangeException(nameof(operation), "The math operator is not supported");

           // var ex= new ArgumentOutOfRangeException(nameof(operation), "The math operator is not supported");
           // ex.Data.Add(key:"Given_Operation",value:operation);
           // throw ex;


            throw new CalculationOperationNotSupportedException("vvv"); 
         }  
     
    }

    private int Divide(int number, int divisor) => number / divisor;
}

