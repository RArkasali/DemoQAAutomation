Feature: WebTables Verification of the details post submission

@webtables @elements @regression
Scenario: WebTables Verification of the details post submission
	Given User navigate the application
	And User clicks on Elements link
	When User clicks on WebTables link on Elements page
	Then User validate navigation goes to Web Tables page
	And User clicks on edit link
	When User update the first name for the record
	Then User validate the first name in the web table 