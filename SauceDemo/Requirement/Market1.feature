Feature: SD_C1_Buy

@tag3
Scenario: [Login in SauceDemo WebSite and Buying one item from the store]
	Given [I have navigated to SauceDemo website]
	Given [I have entered Login Detail]
	Given [I buy one item from the store]
	Then  [I add to cart and finish shopping]
	Then  [Close WebSite]
	
