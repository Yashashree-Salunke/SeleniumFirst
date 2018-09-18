Feature: CreateUser
	Successful user registration with valid details
@mytag
Scenario: Registration of user with valid details
Given I am on the Index page	
When I click on Create new link	
And I fill all the details on the Create user page
And I Click on Create button
Then I navigate to the Index page



