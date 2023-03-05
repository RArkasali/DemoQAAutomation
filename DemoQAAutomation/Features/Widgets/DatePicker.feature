Feature: DatePicker Verification of the details post submission

@datepicker @widgets @regression
Scenario: DatePicker Verification of the details post submission
	Given User navigate the application
	And User clicks on Widgets link
	When User clicks on Date Picker link on widgets page
	Then User validate navigation goes to Date Picker page
	And User enter data in start date text field
	And User enter data in date and time text field
