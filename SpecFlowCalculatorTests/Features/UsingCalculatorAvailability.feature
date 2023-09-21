Feature: UsingCalculatorAvailability

Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
MTBF = MTTF + MTTR
Availability = MTTF / MTBF

@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 500 and 10 into the calculator and press MTBF
	Then the availability result should be 510

@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 500 and 500 into the calculator and press Availability
	Then the availability result should be 1

@Availability
Scenario: Calculating MTBF with zero
	Given I have a calculator
	When I have entered 0 and 500 into the calculator and press MTBF
	Then the availability result should be 500

@Availability
Scenario: Calculating Availability with zero
	Given I have a calculator
	When I have entered 0 and 500 into the calculator and press Availability
	Then the availability result should be 0