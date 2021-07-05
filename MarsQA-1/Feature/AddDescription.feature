Feature: AddDecription
	Adding Decription to profile page
@desctag
Scenario: Add Decription to profile
	Given I am in the profile page
	When i add Decription
	Then the Decription should be added successfully

Scenario: Update Decription to profile
    Given I am in the profile page
	When i Update Decription 
	Then the Decription should be updated successfully





	