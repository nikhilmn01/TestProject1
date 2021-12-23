Feature: Feature_e2e

A short summary of the feature

#@tag1
#Scenario: Navigation bar validation
#	Given Consultancy website url is = "https://compendiumdev.co.uk/default.php"
#	When clicked on each tab, starting with hireme
#	Then hireme tab should be openend
#	Then Navigate back to home page for next operation
#
#	When clicked on e-training tab
#	Then e-training tab should be opened
#	Then Navigate back to home page for next operation
#	
#	When clicked on books tab
#	Then books tab should be opened 
#	Then Navigate back to home page for next operation
#
#	When clicked on face_to_face tab
#	Then face_to_face tab should be opened 
#	Then Navigate back to home page for next operation
#
#	When clicked on about tab
#	Then about tab should be opened
#	Then Navigate back to home page for next operation
#	
#	When clicked on contact tab
#	Then contact tab should be opened 
#	Then Navigate back to home page for next operation
#
#	When clicked on join e-mail list tab
#	Then e-mail list tab should be opened 
#	Then Navigate back to home page for next operation
#
#	When clicked on blog tab
#	Then blog tab should be opened
#	Then Navigate back to home page for next operation
#
#@tag2
#Scenario: social media icons validation
#	Given Consultancy website url is = "https://compendiumdev.co.uk/default.php"
#	When among multiple social media icons, when clicked on each icon starting with email
#	Then email site should be open
#	Then Navigate back to home page for next operation
#
#	When when clicked twitter icon
#	Then twitter site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked youtube icon
#	Then youtube site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked linkedIn icon
#	Then linkedIn site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked gitHub icon
#	Then gitHub site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked pinterest icon
#	Then pinterest site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked instagram icon
#	Then instagram site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked facebook icon
#	Then facebook site should be opened
#	Then Navigate back to home page for next operation
#
#	When when clicked rss icon
#	Then rss site should be opened
#	Then Navigate back to home page for next operation
#
#Scenario: Send a message 
#	Given Consultancy website url is = "https://compendiumdev.co.uk/default.php"
#	When  user tries to send a message with name = "Test", email = "test@abc.com" and body = "Test_Message" and clicks on send
#	Then iFrame message should be sent successfully

Scenario: Individul hyperlinks validation

	Given Consultancy website url is = "https://compendiumdev.co.uk/default.php"
	When clicked on richardson hyperlink
	Then email site should be open
	Then Navigate back to home page for next operation

	When clicked on Join Our Email List
	Then e-mail list tab should be opened 
	Then Navigate back to home page for next operation

	When clicked on evil tester blog
	Then blog tab should be opened
	Then Navigate back to home page for next operation
	
	When clicked on experience years
	Then linkedIn site should be opened
	Then Navigate back to home page for next operation

	When students taught online hyperlink is clicked
	Then e-training tab should be opened
	Then Navigate back to home page for next operation

	When books authored hyperlink is clicked
	Then books tab should be opened 
	Then Navigate back to home page for next operation



