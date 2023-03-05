Feature: Windows Verification of the details post submission

@windows @alertsAndFrames @regression
Scenario: Windows Verification of the details post submission
	Given User navigate the application
	And User clicks on Alerts link
	When User clicks on Windows link on alerts and frames page
	Then User validate navigation goes to Browser Windows page
	And User clicks on New Tab button on windows page
	And User verify the message as This is a sample page in new page and tab
	And User clicks on New Window button on windows page
	And User verify the message as This is a sample page in new page and tab
	And User clicks on New Window Message button on windows page
	And User verify the message as Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization. in new page and tab
	