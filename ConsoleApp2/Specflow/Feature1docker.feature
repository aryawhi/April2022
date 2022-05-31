Feature: Feature1 docker

Test user story
I would like to create profile details. so that I can manage profile details successfully. 


Scenario: Add language details in profile with valid data
	Given logged in to Mars Logo home page
	When  Navigate to Mars Logo profile 
	And   User filled the language details and saved
	Then The Language details should be added successfully.


	
Scenario: Add Skills details in profile with valid data
	Given logged in to Mars Logo home page
	When Navigate to Mars Logo profile 
	And  User filled the skills details and saved
	Then The skills details should be added successfully.


	
Scenario: Add Description details in profile with valid data
	Given logged in to Mars Logo home page
	When Navigate to Mars Logo profile 
	And  User filled the description details and saved
	Then The Description details should be added successfully.



