Feature: sample

A short summary of the feature


@tag1
Scenario: 1 Practice site register
	Given to register_username:"nmntest24" and password:"Test_at_qualitest" is given
	When user register to the site
	Then verify the registration


@tag2
Scenario: 2 Practice site login
	Given username:"nmntest23" and password:"Test_at_qualitest" is given
	When user login to the site
	Then verify the login

@tag3
Scenario: 3 outlook login validation
	Given user outlook ID:"nmntest1" and password:"Test_at_qualitest" is given
	When user login to outlook
	Then verify user is able to login successfully

@tag4
Scenario: 4 outlook invalid login validation
	Given user outlook ID:"nmntest1" and password:"Test_at_qualitest123" is given
	When usertry to login to outlook
	Then verify error message is shown

@tag5
Scenario: 5 outlook sending message scenario
	Given user outlook ID:"nmntest1" and password:"Test_at_qualitest" is given
	And upon successful login
	When user try to send the mail
	Then message should be sent successfully


@tag6
Scenario: 6 outlook sending message invalid scenario
	Given user outlook ID:"nmntest1" and password:"Test_at_qualitest" is given
	And upon successful login
	When user try to send the mail without recepient email id
	Then error message should be shown successfully