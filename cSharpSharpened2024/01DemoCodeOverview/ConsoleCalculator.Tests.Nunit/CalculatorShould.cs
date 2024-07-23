using NUnit.Framework;

namespace ConsoleCalculator.Tests.Nunit
{
    public class CalculatorShould
    {
        

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            //Assert.That(() => sut.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>());

            //fail
            //Assert.That(() => sut.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>()
            //    .With
            //    .Property("Operation").EqualTo("+"));


            //pass
            //var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            //Assert.That(ex!.Operation, Is.EqualTo("+"));

            //fail
            //Assert.That(() => sut.Calculate(2, 2, "+"), Throws.TypeOf<CalculationException>());

            //pass
            Assert.That(() => sut.Calculate(2, 2, "+"), Throws.InstanceOf<CalculationException>());









        }
    }
}