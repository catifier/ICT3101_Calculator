Feature: UsingCalculatorLogarithmicReliability

A short summary of the feature

@LogarithmicMusa
Scenario: Calculate the Logarithmic Musa Failure Intensity
	Given I have a calculator
	When I have entered 6 and 1 and 0.02 into the calculator and press logarithmic musa failure intensity
	Then the logarithmic musa result should be 5.8811920398405313

@LogarithmicMusa
Scenario: Calculate the Logarithmic Musa Average Number of Failures
	Given I have a calculator
	When I have entered 6 and 1 and 0.02 into the calculator and press logarithmic musa average number of failures
	Then the logarithmic musa result should be 5.6664342653501638