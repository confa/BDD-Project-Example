Feature: Recipe
	In order to get access to recipe book
	As a user
	I want to be able to logging into the system

@Recipes
Scenario: Login
	Given I am on the "Login" page
	When I have entered my credentials
	| user | password |
	| user | 123456   |
	And I have pressed "Log in" button
	Then I should be on "Index" page
	And I should see the text "Hello, user!"

Scenario: Recipe name
	Given I am logged as "user"
	And I am on the "Recipe" page
	When I put text "This is awesome recipe" to "Description" field
	And I have pressed "Send" button
	Then I should see the text "Please enter the recipe name"

Scenario: Ingredient amount
	Given I am logged as "user"
	And I am on the "Recipe" page
	And I have selected "Squash" from ingredients
	When I have pressed "Add" button
	Then I should see the text "Please input valid numeric amount."

Scenario: Recipe
	Given I am logged as "user"
	And I am on the "Recipe" page
	When I put text "This is awesome recipe" to "Name" field
	And I have selected "Egg" from ingredients
	And I put text "100" to "Amount" field
	And I have pressed "Add" button
	And I have selected "Cucumber" from ingredients
	And I put text "100" to "Amount" field
	And I have pressed "Add" button
	And I put text "This is awesome description" to "Description" field
	And I have pressed "Send" button
	Then I should see the text "This is awesome recipe"
	And I should see the text "This is awesome description"