Feature: Login to the website
	In order to login
	As a valid user
	I need to pass the correct credentials

@webChrome
Scenario: I can login to the website using valid credentials
	Given  I access the login page
	When I login to the webpage using valid credentials
	Then I will be successfully logged in