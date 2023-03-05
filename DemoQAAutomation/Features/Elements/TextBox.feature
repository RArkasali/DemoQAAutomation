Feature: TextBox Verification of the details post submission

@textbox @elements @regression
Scenario: TextBox Verification of the details post submission
	Given User navigate the application
	And User clicks on Elements link
	When User clicks on TextBox link on Elements page
	Then User validate navigation goes to Text Box page
	And User enter the full name in textbox
	And User enter the email address in textbox
	And User enter the current address in textbox
	And User enter the permanent address in textbox
	When User clicks on submit button
	Then User verify the details post submission