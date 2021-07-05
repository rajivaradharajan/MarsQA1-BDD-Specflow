Feature: AddSkills
	Adding Skills to profile page
@langtag
Scenario: Add Skills to profile
	Given I am in the profile page
	When i add Skills
	Then the Skills should be added successfully

Scenario: Update Skills to profile
    Given I am in the profile page
	When i Update Skills 
	Then the Skills should be updated successfully

Scenario: Delete Skills from profile
    Given I am in the profile page
	When i Delete Skills
	Then the Skills should be deleted successfully

