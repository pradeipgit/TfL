Feature: ReqRes
	In order to proceed to next stage of interview
	As a job applicant
	I have to complete Automation Tester Coding Challenge 

Scenario: Verify that a POST request can be posted to the API to create the single user and assert that the single user is created
	Given I have an end point for POST user request
	When I made a request to create a user with name "morpheus" and job "leader"
	Then the response should be successful
	And the new user should be created

Scenario: Verify that a GET request can be posted to the API to get the expected details of single user 
	Given I have an end point for GET user request
	When I made a request to get an user with user id "2"
	Then the response should return all the user details 
	
Scenario: Verify that a GET request can be posted to the API to get the expected details of the list of users 
	Given I have an end point for GET list of users
	When I made a request to get all users list
	Then the response should return all the available users

Scenario: Verify that a PUT request can be posted to the API to update the single user and assert that the expected update was made
	Given I have an end point for PUT request
	When I made a request to update the user name to "pradeep" for user id "2"
	Then the response should be successful
	And the user name should be updated

Scenario: Verify that a GET request can be posted to the API to return a single user not found, which should return a “404” response
	Given I have an end point for GET list of users
	When I made a request to get an user with user id "23"
	Then the response code should be "404" 
