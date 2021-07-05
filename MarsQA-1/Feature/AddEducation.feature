Feature:  AddEducation
	Adding Education to profile page
@langtag
Scenario: Add Education to profile
	Given I am in the profile page
	When i add Education
	Then the Education should be added successfully

Scenario: Update Education to profile
    Given I am in the profile page
	When i Update Education 
	Then the Education should be updated successfully

Scenario: Delete Education from profile
    Given I am in the profile page
	When i Delete Education
	Then the Education should be deleted successfully

