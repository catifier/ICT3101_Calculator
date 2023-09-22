Feature: UsingCalculatorDefectDensity

In order to calculate the Defect Density metrics
As a Software Quality Metric enthusiast
I want to use my calculator to do this

# US1:
# As an Engineer,
# I want to calculate the defect density of a system
# So that I can perform quality metric calculations

@DefectDensity
Scenario: Calculate the defect density
	Given I have a calculator
	When I have entered 6 and 3 into the calculator and press defect density
	Then the defect density result should be 2

@DefectDensity
Scenario: Calculate the defect density with zero defects
	Given I have a calculator
	When I have entered 0 and 3 into the calculator and press defect density
	Then the defect density result should be 0

# US2:
# As an Engineer,
# I want to perform custom calculation for the new total number of Shipped Source Instructions (SSI) in the successive releases of a system
# So that I can perform quality metric calculations

@DefectDensity
Scenario: Calculate the new SSI
	Given I have a calculator
	When I have entered 50 and 30 and 10 and 10 into the calculator and press SSI
	Then the defect density result should be 60

@DefectDensity
Scenario: Calculate the new SSI with zero old / changed / deleted code.
	Given I have a calculator
	When I have entered <value1> and <value2> and <value3> and <value4> into the calculator and press SSI
	Then the defect density result should be <value5>
	Examples:
	| value1 | value2 | value3 | value4 | value5 |
	| 0      | 30     | 0      | 0     | 30     |
	| 50     | 30     | 0      | 0     | 80     |
	| 50     | 30     | 10     | 0     | 70     |
	| 50     | 30     | 0      | 10    | 70     |

