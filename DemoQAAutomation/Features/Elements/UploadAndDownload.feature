Feature: Upload And Download Verification of the details post submission

@uploadanddownload @regression @elements
Scenario: Upload And Download Verification of the details post submission
	Given User navigate the application
	And User clicks on Elements link
	When User clicks on Upload And Download link on Elements page
	Then User validate navigation goes to Upload and Download page
	When User Upload the file on the upload and download page
	Then User verifies a Upload has done successfully
	When User Download the file on the upload and download page
	Then User verifies a Download has done successfully
