Feature: Buttons Verification of the details post submission

@buttons @elements @regression
Scenario: Buttons Verification of the details post submission
	Given User navigate the application
	And User clicks on Elements link
	When User clicks on Buttons link on Elements page
    Then User validate navigation goes to Buttons page
	When User click on Double Click
	Then User verify the Double Click message as You have done a double click
	When User click on Right Click
	Then User verify the Right Click message as You have done a right click
	When User click on Dynamic Click
	Then User verify the Dynamic Click message as You have done a dynamic click