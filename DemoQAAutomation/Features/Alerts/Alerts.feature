Feature: Alerts Verification of the details post submission

@alerts @alertsAndFrames @regression
Scenario: Alerts Verification of the details post submission
	Given User navigate the application
	And User clicks on Alerts link
	When User clicks on Alerts link on alerts and frames page
	Then User validate navigation goes to Alerts page
	And User clicks on see alert button
	And User verify the pop up message for alert as You clicked a button
	And User clicks on see alert button for appear after 5 seconds
	And User waits for 5 seconds
	And User verify the pop up message for alert as This alert appeared after 5 seconds
	And User clicks on comfirm box alert pop up
	And User accept the alert
	And User verifies the You selected Ok
	And User clicks on comfirm box alert pop up
	And User rejects the alert
	And User verifies the You selected Cancel
	And User clicks on prompt box alert pop up
	And User enter the data in pop up alert
	And User verifies the You entered
