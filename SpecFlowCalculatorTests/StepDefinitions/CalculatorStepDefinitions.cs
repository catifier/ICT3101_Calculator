using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private double _result;

        // Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}