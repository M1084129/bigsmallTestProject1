Feature: Bigsmall 
	bigsmall functional testing

@mytag
Scenario Outline: login
	Given home page of the website
	When user click on sign in 
	And User enter <username> and <password>
	And user enter on click on login button
	Then the result 
Examples: 
	| username   | password |
	| testuser_1 | Test@123 |
	| testuser_2 | Test@153 |

Scenario Outline: Create Account
	Given home page of the website
	When user click on sign in 
	And click on create account
	And User Enter <firstname>,<lastname>,<email>,<password>
	And user enter on click on create button
	Then the result 
Examples: 
	|firstname  |lastname  |email  |password |
	|test1|user1|testuser_1|Test@123 |
	|test2|user2|testuser_2|Test@153 |

Scenario: Add to Qty
	Given home page of the website
	When user click on PersonalizedGift
	And user click on item
	And user click on Add Qty
	Then the result

Scenario: Add to Cart
	Given home page of the website
	When user click on sale
	And user click on Item
	And user Add Qty
	And user click on Add to Cart
	And user click on Checkout
	Then Continue Shopping

Scenario: Add Gift to Wishlist
	Given home page of the website
	When user click on Gift
	And select Gift Card
	And select Qty
	And Add to Wishlist 
	Then the result