Feature: This Test suite Contains test scenarios for language module
1.Create Language
2.Edit language
3.Delete Language

Scenario Outline: A. Create a new Language record
Given User log into Mars portal
When User navigate to Language module
And User create a new Language record <Language> <Level>
Then the tooltip message should be "<Language> has been added to your languages"

Examples: 
| Language   | level           |
| 'English   | 'Basic          |
| 'Hindi'    | 'Conversational |
| 'Japanese' | 'Native'        |
| 'French'   | 'Fluent'        |

Scenario: D. Create a language record without data
Given User log into Mars portal
And User create a new language record without data
Then the tooltip message should be "please enter language and level"

Scenario: C. Create a language record with duplicate data
Given User log into Mars portal
And User create a new language record 'English' 'Basic'
Then the tooltip message should be "This language is already exist in your language list"

Scenario Outline: B. Check the limit of the Language records
Given User log into the Mars portal
And User add Four language record <Language> <Level>
Then  the AddNewButton Does Not exist

Examples: 
| Language   | Level    |
| 'English'  | 'Basic'  |
| 'Hindi'    | 'Native' |
| 'Japanese' | 'Native' |
| 'French'   | 'Fluent' |

Scenario Outline: E.Edit an existing Language record
Given User log into Mars portal
When User navigate to Language module
And User edit an existing record <oldLanguage> <newLanguage> <oldLevel> <newLevel>
Then the tooltip message should be "<newLanguage> has been updated to your languages"

Examples: 
| oldLanguage | newLanguage | odlLevel         | newLevel         |
| 'Hindi'     | 'Spanish'   | 'Conversational' | 'Basic'          |
| 'Japanese'  | 'French'    | 'Native'         | 'Conversational' |

Scenario: F. Delete an existing language record
Given User log into Mars portal
When User navigate to language module
And User delete an existing Language record 'French'
Then the tooltip message should be "French has been deleted from your languages"

