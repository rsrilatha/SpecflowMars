Feature: This test Suite contains test scenarios for Skill module
1.Create Skill
2.Edit Skill
3.Delete Skill

Scenario Outline: A. Create a new Skill record
Given  User logs into Mars portal
When  User navigate to skill module
And  user create a new skill record <Skill> <Level>
Then tooltip message should be "<skill> has been added to your skills"

Examples: 
| Skill      | Level          |
| 'Specflow' | 'Beginner'     |
| 'Github'   | 'Intermediate' |
| '@1234'    | 'Beginner'     |
| 'Music'    | 'Expert'       |

Scenario: B. Create a Skill record without data
Given User logs into Mars portal
When User navigate to Skill module
And user create a new skill record without data
Then tooltip message should be "please enter skill and experience level"

Scenario: C. Create a skill record with duplicate data
Given  User logs into MARS portal
When User navigate to Skill module
And User create a new Skill record 'Specflow' 'Beginner'
Then tooltip message should be "this skill is already exist in your skill list"

Scenario Outline: D. Edit an existing Skill record
Given User logs into Mars portal
When User navigates to Skill moudle'
And User edit an existing skill record <oldSkill> <newSkill> <oldLevel> <newLevel>
Then tooltip message should be "<newSkill> has been updated to your skill"

Examples: 
| oldSkill   | newSkill   | oldLevel       | newLevel       |
| 'Specflow' | 'Beginner' | 'Cucumber'     | 'Intermediate' |
| 'Github'   | 'Java'     | 'Intermediate' | 'Beginner'     |

Scenario: E. Delete an existing Skill record
Given  User logs into Mars portal
When User navigate to Skill module
And User delete an existing Skill record 'Java'
Then tooltip message should be "Java has been deleted"