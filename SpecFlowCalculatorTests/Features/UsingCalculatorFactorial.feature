Feature: UsingCalculatorFactorial

In order to calculate the Factorial
As a Bean Counter
I want to use my calculator to do this

@Factorials
Scenario: Factorial of a number
	Given I have a calculator
	When I have entered 5 into the calculator and press factorial
	Then the factorial result should be 120

@Factorials
Scenario: Factorial of zero
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial
	Then the factorial result should be 1