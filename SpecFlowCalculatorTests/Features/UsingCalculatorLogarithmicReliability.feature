Feature: UsingCalculatorLogarithmicReliability

In order to calculate the Logarithmic Musa Reliability metrics
As a Software Quality Metric enthusiast
I want to use my calculator to do this

# US3:
# As an Engineer,
# I want to use the Musa Logarithmic model for calculations
# So that I can perform quality metric calculations

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

@LogarithmicMusa
Scenario: Calculate the Logarithmic Musa Failure Intensity with an expected number of failure of 0
	Given I have a calculator
	When I have entered 6 and 0 and 0.02 into the calculator and press logarithmic musa failure intensity
	Then the logarithmic musa result should be 6

@LogarithmicMusa
Scenario: Calculate the Logarithmic Musa Average Number of Failures at time 0
	Given I have a calculator
	When I have entered 6 and 0 and 0.02 into the calculator and press logarithmic musa average number of failures
	Then the logarithmic musa result should be 0