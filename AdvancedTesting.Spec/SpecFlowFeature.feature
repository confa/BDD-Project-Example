Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Calculator
Scenario: Add two numbers
	Given I have entered "5" and "6" for calculation
	When I press add
	Then the result should be "11" on the screen