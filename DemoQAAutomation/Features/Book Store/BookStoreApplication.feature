Feature: Book Store Application Verification of the details post submission

@bookstore @bookstroreapplication @regression
Scenario: Book Store Application Verification of the details post submission
	Given User navigate the application
	And User clicks on Book Store link
	When User clicks on Login link on book store application page
	Then User validate navigation goes to Login page
	And User clicks on new user button
	And User enter the FirstName in textbox for registration page
	And User enter the LastName in textbox for registration page
	And User enter the UserName in textbox for registration page
	And User enter the Password in textbox for registration page
	And User clicks on captcha button
	And User clicks on registraion button
	And User verfies the registration message User Register Successfully.
	And User clicks on login back button
	And User enter the UserName in textbox for login page
	And User enter the Password in textbox for login page
	And User clicks on login button
	And User verfies the login message Log out