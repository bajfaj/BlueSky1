Feature: Registration
	As a user of the site
	I would like to register
	so that I can login to the site

@mytag
Scenario: Navigating to the Registration Page
	Given I navigate to the site
	When I click on the register link
	Then the registration page is displayed

Scenario: User Login
	Given I input user login details on the site
	When I click on the login button
	Then the user homescreen is displayed 