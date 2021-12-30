Feature: BitCoins

Scenario: BitCoins Website graph
Given When user enters the url = "https://www.coindesk.com/price/bitcoin/"
When user hovers over the graph at date = "30 Dec" and time = "03:18"
Then should get the appropriate price at that point
