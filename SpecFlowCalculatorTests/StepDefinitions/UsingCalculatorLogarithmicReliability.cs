using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorLogarithmicReliability
    {
        private double _result;
        private Calculator _calculator;
        public UsingCalculatorLogarithmicReliability(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press logarithmic musa failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicCurrentFailureIntensity(double p0, double p1, double p2)
        {
            _result = _calculator.LogarithmicMusaCurrentFailureIntensity(p0, p1, p2);
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press logarithmic musa average number of failures")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicAverageNumberOfFailures(double p0, double p1, double p2)
        {
            _result = _calculator.LogarithmicMusaAverageNumberOfFailures(p0, p1, p2);
        }

        [Then(@"the logarithmic musa result should be (.*)")]
        public void ThenTheLogarithmicMusaResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}