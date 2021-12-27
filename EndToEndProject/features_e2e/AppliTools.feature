Feature: AppliTools

A short summary of the feature


Scenario: 1. Youtube Player validation
	Given the url of the website "https://applitools.com/"
	When clicked on play button of mini player
	When seeked to the near end of the video
	Then should wait until the video is completely played and should validate the same

#Scenario: 2. Home page hover
#	Given the url of the website "https://applitools.com/"
#	When hovered on the navigation bar and validated the same
#	Then there should be no error in validation

Scenario: 3. Login page multiple ui elements to be validated 
	Given the url of the website "https://applitools.com/"
	When user performs valid login with username = "nmn.test.qt@gmail.com" and password = "Test@1234"
	And when user performs validation on the multiple UI elements present on the home page
	Then there should be no error in validation
	Then successful logout should happen


Scenario: 2. Home page hover2
	Given the url of the website "https://applitools.com/"
	When hovered on the navigation bar item <cases> and validated the same
	Then there should be no error in validation
Examples:
| cases   | 
| "Products" |
| "Use Cases" |
| "Resources" |
| "Pricing" |
| "Company" |


