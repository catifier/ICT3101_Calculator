using ICT3101_Calculator;
using Moq;

namespace ICT3101_Caculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        private object _fileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
                fr.Read("../../../../MagicNumbers.txt")).Returns(new string[]{"4", "0", "3", "2", "\t", "8", "7", "4", "0", "2", "9", "3", "7", "4", "7", "3", "2", "0", "9", "6", "5", "0", "4", "3", "9", "7", "5", "6", "4", "3", "-8", "5", "6", "2", "7"});
            _calculator = new Calculator();
        }
        [Test]
        public void GenMagicNum_WhenGivenZero_ResultEqualToEight()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void GenMagicNum_WhenGiven1_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven20_ResultEqualTo10()
        {
            // Act
            double result = _calculator.GenMagicNum(20, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void GenMagicNum_WhenGiven30_ResultEqualToNegative16()
        {
            // Act
            double result = _calculator.GenMagicNum(30, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(16));
        }
        [Test]
        public void GenMagicNum_WhenGiven34_ResultEqualTo14()
        {
            // Act
            double result = _calculator.GenMagicNum(34, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(14));
        }
        [Test]
        public void GenMagicNum_WhenGivenMinus1_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(-1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven100_ResultEqualToZero()
        {
            // Act
            double result = _calculator.GenMagicNum(100, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGiven4_ResultThrowException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.GenMagicNum(4, _mockFileReader.Object), Throws.Exception);
        }
    }
}
