using FinalExercise.Modules;

namespace FinalExercise.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(150,50)==200);
        }
        
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator=new Calculator();
            Assert.True(calculator.Subtraction(150,50)==100);
        }
        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(150,50)==7500);
        }
        
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(150,50)==3);
        }
        [Test]
        public void DivisionOnZeroMustReturnDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Division(150,0));
        }
    }
}