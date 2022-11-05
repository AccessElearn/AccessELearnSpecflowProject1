Feature: Login

In order to use the application I should be logged in

@tag1
Scenario Outline: As a user I want to be able to login with my username and password
	Given I navigate to "http://automationpractice.com/index.php"
	When I click on the SignInButton
	And I eneter my "<userName>" and "<Password>"
	And I click on the LoginSignIn button
	Then I should be looged into the application

	Examples: 
	| userName           | Password     |
	| Jboy@yahoo.com     | AugBatch2022 |
	| fdjdfjfd@yahoo.com | djhfdhjfdj   |
	 
	
	
	
	