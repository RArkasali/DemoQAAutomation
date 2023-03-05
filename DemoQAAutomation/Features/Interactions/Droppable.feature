Feature: Droppable Verification of the details post submission

@dropable @interactions @regression
Scenario: Droppable Verification of the details post submission
	Given User navigate the application
	And User clicks on Interactions link
	When User clicks on Droppable link on interactions page
	Then User validate navigation goes to Droppable page
	And User drag the item to the drop able place
	And User verifies a color change of the droppable box