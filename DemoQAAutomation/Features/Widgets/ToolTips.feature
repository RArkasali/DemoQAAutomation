Feature: Tool Tips Verification of the details post submission

@tooltips @widgets @regression
Scenario: Tool Tips Verification of the details post submission
	Given User navigate the application
	And User clicks on Widgets link
	When User clicks on Tool Tips link on widgets page
	Then User validate navigation goes to Tool Tips page
	And User mouse hover the "button"
	And User verify mouse hover message as You hovered over the Button
	And User mouse hover the "textfield"
	And User verify mouse hover message as You hovered over the Button
