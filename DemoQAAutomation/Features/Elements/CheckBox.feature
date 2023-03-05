Feature: CheckBox Verification of the details post submission

@checkbox @elements @regression
Scenario: CheckBox Verification of the details post submission
	Given User navigate the application
	And User clicks on Elements link
	When User clicks on CheckBox link on Elements page
	Then User validate navigation goes to Check Box page
	And User clicks on expand all button
	And User selects Notes checkbox
	And User selects Private checkbox
	And User validate the success message includes Notes,Private