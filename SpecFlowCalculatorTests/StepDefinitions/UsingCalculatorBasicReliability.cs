using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorBasicReliability
    {
        private double _result;
        private Calculator _calculator;
        public UsingCalculatorBasicReliability(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press basic current failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressBasicCurrentFailureIntensity(double p0, double p1, double p2)
        {
            _result = _calculator.BasicMusaCurrentFailureIntensity(p0, p1, p2);
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press basic average number of expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressBasicAverageNumberOfFailures(double p0, double p1, double p2)
        {
            _result = _calculator.BasicMusaAverageNumberOfFailures(p0, p1, p2);
        }

        [Then(@"the basic musa result should be (.*)")]
        public void ThenTheBasicMusaResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}