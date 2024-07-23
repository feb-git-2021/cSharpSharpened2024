namespace ConsoleCalculator
{
    public class CalculationException:Exception
    {
        private const string DefaultMessage = "An error occured during calculation. Ensure that the operator is supported and the values are within the range of requested operation.";
        ///<summary>
        ///Creates a new CalculationException
        ///</summary>

        public CalculationException() : base(DefaultMessage) { }

        public CalculationException(string message) : base(message) { }

        public CalculationException(Exception innerException) : base(DefaultMessage,innerException) { }

        public CalculationException(string message,Exception innerException) : base(message, innerException) { }


    }
}
