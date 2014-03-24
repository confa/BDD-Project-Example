Feature: UserSpecFlow
	In order to make possible login
	As a user
	I want to be able to log as user

Scenario Outline: Multiply two numbers
    Given I have entered <firstNumber>
    And I have entered <secondNumber>
    When I press = button
    Then result should be <result>

Examples: 
| firstNumber | secondNumber | result |
| 3           | 3            | 9      |
| 10          | 2            | 20     |
| 3           | 0            | 0      |
