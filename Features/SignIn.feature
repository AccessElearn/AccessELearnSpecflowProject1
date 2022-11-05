Feature: RegisterUser

In order to be able to use the application, I should register as a user

@tag1
Scenario: 0As a user I should be able to create an account
	Given I navigate to the website "http://automationpractice.com/index.php"
	When I click on the SignIn button
	And I enter my email adddress as "Jboy@yahoo.com"
	And I click on the create an account button 
	Then Your personal information page should be displayed

    @Tag2
    Scenario: 1I want to be able to enter my personal information.
    Given I click on the title button
    And I enter my firstName and LastName
    When I enter my password
    And I select my date of birth

    @Tag3
	Scenario: 2I want to be able to complete the your personal information form so that I can be registered  
	Given I enter my address fields and values as below 
    | Fields                | Values           |
    | AddressFirstName      | EveryOne         |
    | AddressLastName       | Good             |
    | Address               | 10 xyz way       |
    | City                  | Oslo             |
    | State                 | Alaska           |
    | Zip/PostalCode        | 81636            |
    | AdditionalInformation | Every where Good |
    | HomePhoneNumber       | 045421225        |
    | MobilePhoneNumber     | 0784545555       |
    | AddressAlias          | Selenium         |  
    And I click on the register button
    Then I should be registered

    
