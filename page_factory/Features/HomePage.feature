Feature: HomePage
	
Background: 
			Given I am on the / page

Scenario Outline: The header links navigate to the correct pages
			When I click the <link> header link
			Then I am redirected to the /<url> url
			And the page has correct <link> – Daehyun Kim title
			Examples: 
			| link    | url        |
			| About   | Home/About |
			| Contact | Feedback   |

Scenario: The artist's quote is shown on the home page
			Then the following quote is shown on the main page:
			| quote                                                         |
			| If the artist can disappear and hide well,                    |
			| people find meaningful and important something from the work. |
			| I don't want to disturb the process.                          |
       
Scenario: The footer contains correct social icons links and copyrite message
			Then social links have correct urls:
			| url                                           |
			| facebook.com/daehyun.kim                      |
			| pinterest.com/pin/102245854017904870/?lp=true |
			| instagram.com/explore/tags/moonassi/          |
			And the copyright message is shown:
			| message                       |
			| Copyright © Your Website 2017 |



