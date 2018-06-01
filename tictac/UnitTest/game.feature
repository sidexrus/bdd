Feature: Testing class game

  Scenario Outline: After the first player step, the second player takes a step
    Given game
    When firts player made a step
    Then game give step to second player

