Feature: UsingCalculatorDefectDensity

A short summary of the feature

@DefectDensity
Scenario: Calculate the defect density
	Given I have a calculator
	When I have entered 6 and 3 into the calculator and press defect density
	Then the defect density result should be 2

@DefectDensity
Scenario: Calculate the new SSI
	Given I have a calculator
	When I have entered 50 and 30 and 10 and 10 into the calculator and press SSI
	Then the defect density result should be 60