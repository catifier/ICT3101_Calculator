using Microsoft.VisualStudio.TestPlatform.ObjectModel.Host;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorDefectDensity
    {
        private double _result;
        private Calculator _calculator;
        public UsingCalculatorDefectDensity(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press defect density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(int p0, int p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }

        [When(@"I have entered (.*) and (.*) and (.*) and (.*) into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(int p0, int p1, int p2, int p3)
        {
            _result = _calculator.SSI(p0, p1, p2, p3);
        }

        [Then(@"the defect density result should be (.*)")]
        public void ThenTheDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}