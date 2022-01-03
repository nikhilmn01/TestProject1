Feature: BitCoins

Scenario: BitCoins Website graph
Given When user enters the url = "https://www.coindesk.com/price/bitcoin/"
When user hovers over the graph at date = "2 Jan 2022" and time = "22:16" or "22.15"
Then should get the appropriate price at that point
