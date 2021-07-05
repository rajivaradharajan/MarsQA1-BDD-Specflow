Feature: Add Certifications
	Adding Certifications to profile page
@langtag
Scenario: Add Certifications to profile
	Given I am in the profile page
	When i add Certifications
	Then the Certifications should be added successfully

Scenario: Update Certifications to profile
    Given I am in the profile page
	When i Update Certifications 
	Then the Certifications should be updated successfully

Scenario: Delete Certifications from profile
    Given I am in the profile page
	When i Delete Certifications
	Then the Certifications should be deleted successfully

