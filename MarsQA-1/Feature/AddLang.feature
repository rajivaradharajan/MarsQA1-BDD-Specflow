Feature: Addlanguage
	Adding languages to profile page
@langtag
Scenario: Add language to profile
	Given I am in the profile page
	When i add language
	Then the language should be added successfully

Scenario: Update language to profile
    Given I am in the profile page
	When i Update Language 
	Then the language should be updated successfully

Scenario: Delete language from profile
    Given I am in the profile page
	When i Delete language
	Then the language should be deleted successfully

