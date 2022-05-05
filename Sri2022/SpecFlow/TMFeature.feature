Feature: TMFeature

As a turn up portal admin 
I would like to create, edit and delete time and material records
so that I can manage employees time and materials successfully

@regression
Scenario: create time and material record with valid details
	Given I logged in to turn up portal successfully
	When I navigate to Time and Material page
	When I create a new time and material record
	Then the record should be created successfully

