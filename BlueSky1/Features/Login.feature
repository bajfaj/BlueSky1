Feature: Login
	As a registered user of Giftree
	i would like to login
	so that i can use the site
	

@mytag
Scenario: Valid Login - Valid username and valid password
	Given i navigate to the site
	When i click on login link
	And I enter a valid username
	And i enter a valid password
	And I click on login button
	#Then user should login succesfully

Scenario:  Invalid Login - valid username and invalid password
    Given i navigate to the site
	And I enter a valid username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and valid password
    Given i navigate to the site
	And I enter an invalid username and valid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and invalid password
    Given i navigate to the site
	And I enter invalid username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and empty password
    Given i navigate to the site
	And I enter no username and no password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and valid password
    Given i navigate to the site
	And I enter no username and valid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and invalid password
    Given i navigate to the site
	And I enter no username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - valid username and empty password
    Given i navigate to the site
	And I enter a valid username and no password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and empty password
    Given i navigate to the site
	And I enter a invalid username and no password
	When I click ok
	Then user should be unable to login



