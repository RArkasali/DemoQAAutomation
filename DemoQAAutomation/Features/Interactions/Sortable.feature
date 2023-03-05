Feature: Sortable Verification of the details post submission

@sortable @interactions @regression
Scenario: Sortable Verification of the details post submission
	Given User navigate the application
	And User clicks on Interactions link
	When User clicks on Sortable link on interactions page
	Then User validate navigation goes to Sortable page
	When User sorts the list in descending order