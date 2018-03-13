Feature: SpecFlowFeature1
	In order to create a new user
	As a tester
	I want to request this from the API

@mytag
Scenario: Create a new test user
	Given I request a new user from the account service
	Then A new user will be returned
