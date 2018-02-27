@default
Feature: Feedback

Background: 
			Given I am on the /Feedback page

Scenario Outline: The feedback links navigate to the correct pages
			When I navigate to the /<page> page
			And click the grey navigation <link> link 
			Then I am redirected to the correct /<url> url
			Examples: 
			| page            | link         | url             |
			| Feedback        | Create New   | Feedback/Create |
			| Feedback/Create | Back to List | Feedback        |

Scenario: The feedbacks are shown in the feedback section
			Then at least two items are shown in the feedback section

Scenario: The required field message is shown when trying to submit the empty form
			When I navigate to the /Feedback/Create page
			And I click the Send a message button
			Then the Name field shows the error message:
			| message               |
			| The name is required. |
			And the Comment field shows the error message:
			| message                  |
			| The comment is required. |

Scenario: The invalid email field message is shown when trying to submit incorrect email value
			When I navigate to the /Feedback/Create page
			And fill in following values:
			| name | email | comment |
			| test | test  | test    |
			And I click the Send a message button
			Then the Email field shows the error message:
			| message                |
			| Invalid email address. |

Scenario: The correct values are submited and displayed on the feedback page
			When I navigate to the /Feedback/Create page
			And fill in following values:
			| name | email            | comment |
			| test | test@example.com | test    |
			And I click the Send a message button
			Then I am redirected to the /Feedback url
			And the data is shown in the feedback section