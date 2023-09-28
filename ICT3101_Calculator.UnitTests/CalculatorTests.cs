using ICT3101_Calculator;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = FileReader.GetInstance();
        }
        //[Test]
        //public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        //{
        //    // Act
        //    double result = _calculator.Add(10, 20);
        //    // Assert
        //    Assert.That(result, Is.EqualTo(30));
        //}
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtraction()
        {
            // Act
            double result = _calculator.Subtract(60, 20);
            // Assert
            Assert.That(result, Is.EqualTo(40));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiplication()
        {
            // Act
            double result = _calculator.Multiply(10, 5);
            // Assert
            Assert.That(result, Is.EqualTo(50));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            // Act
            double result = _calculator.Divide(180, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        /*
        [Test]
        public void Divide_WhenDividingByZero_ResultPositiveInfinity()
        {
            // Act
            double result = _calculator.Divide(500, 0);
            // Assert
            // Something about IEE 754 having infinity
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }
        [Test]
        public void Divide_WhenDividingByZero_ResultNegativeInfinity()
        {
            // Act
            double result = _calculator.Divide(-500, 0);
            // Assert
            // Something about IEE 754 having infinity
            Assert.That(result, Is.EqualTo(double.NegativeInfinity));
        }
        */

        // Original
        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        //{
        //    Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        //}

        // For Specflow
        //[Test]
        //[TestCase(0, 0)]
        //public void Divide_WithTwoZeroesAsInputs_ResultEqualToOne(double a, double b)
        //{
        //    // Act
        //    double result = _calculator.Divide(a, b);
        //    // Assert
        //    Assert.That(result, Is.EqualTo(1));
        //}

        [Test]
        public void Factorial_WithZeroAsInput_ResultEqualToOne()
        {
            // Act
            double result = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Factorial_WhenFactorialOneNumber_ResultEqualToFactorial()
        {
            // Act
            double result = _calculator.Factorial(5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WithDecimalsAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(5.5), Throws.ArgumentException);
        }
        [Test]
        public void TriangleArea_BaseHeightAsInputs_ResultEqualToArea()
        {
            double result = _calculator.TriangleArea(10, 5);
            // Assert
            Assert.That(result, Is.EqualTo(25));
        }
        [Test]
        [TestCase(5, -5)]
        [TestCase(-5, 5)]
        [TestCase(-5, -5)]
        public void TriangleArea_WithNegativeInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.TriangleArea(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void TriangleArea_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.TriangleArea(a, b), Throws.ArgumentException);
        }
        [Test]
        public void CircleArea_RadiusAsInput_ResultEqualToArea()
        {
            double result = _calculator.CircleArea(10);
            // Assert
            Assert.That(result, Is.EqualTo(System.Math.PI * 10 * 10));
        }
        public void CircleArea_WithNegativeInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.CircleArea(-5), Throws.ArgumentException);
        }
        public void CircleArea_WithZeroAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.CircleArea(0), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void GenMagicNum_WhenGivenZero_ResultEqualToEight()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void GenMagicNum_WhenGiven1_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven20_ResultEqualTo12()
        {
            // Act
            double result = _calculator.GenMagicNum(20, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void GenMagicNum_WhenGiven30_ResultEqualToNegative16()
        {
            // Act
            double result = _calculator.GenMagicNum(30, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(16));
        }
        [Test]
        public void GenMagicNum_WhenGiven34_ResultEqualTo34()
        {
            // Act
            double result = _calculator.GenMagicNum(34, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(14));
        }
        [Test]
        public void GenMagicNum_WhenGivenMinus1_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(-1, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven100_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(100, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven4_ResultThrowException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.GenMagicNum(4, _fileReader), Throws.Exception);
        }
    }
}
