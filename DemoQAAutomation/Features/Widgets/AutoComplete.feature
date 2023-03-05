Feature: Auto Complete Verification of the details post submission

@autocomplete @widgets @regression
Scenario: Auto Complete Verification of the details post submission
	Given User navigate the application
	And User clicks on Widgets link
	When User clicks on Auto Complete link on widgets page
	Then User validate navigation goes to Auto Complete page
	And User selects Black for single value text field
	And User verfies value of Black for single text field
