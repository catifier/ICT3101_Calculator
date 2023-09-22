Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicMusa
Scenario: Calculating the current failure intensity
	Given I have a calculator
	When I have entered 6 and 1 and 2 into the calculator and press basic current failure intensity
	Then the basic musa result should be 3

@BasicMusa
Scenario: Calculating the average number of expected failures
	Given I have a calculator
	When I have entered 1 and 2 and 6 into the calculator and press basic average number of expected failures
	Then the basic musa result should be 1.7008121365572644

@BasicMusa
Scenario: Calculating the current failure intensity with an expected number of failure of 0
	Given I have a calculator
	When I have entered 6 and 0 and 2 into the calculator and press basic current failure intensity
	Then the basic musa result should be 6

@BasicMusa
Scenario: Calculating the average number of expected failures at time 0
	Given I have a calculator
	When I have entered 1 and 0 and 6 into the calculator and press basic average number of expected failures
	Then the basic musa result should be 0