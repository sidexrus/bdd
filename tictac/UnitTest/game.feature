Feature: Testing class game

  Scenario Outline: After the first player step, the second player takes a step
    Given game
    When firts player made a step
    Then game give step to second player

  Scenario Outline: The top line consists of three crosses or toes
    Given game
    When when three crosses or toes filled top line
    Then game returns signal
	Examples: game
	|X|X|X|
	| | | |
	| | | |
	or
	|O|O|O|
	| | | |
	| | | |

  Scenario Outline: The left column consists of three crosses or toes
    Given game
    When when three crosses or toes filled left column
    Then game returns signal
	Examples: game
	|X| | |
	|X| | |
	|X| | |
	or
	|O| | |
	|O| | |
	|O| | |

  Scenario Outline: The mid column consists of three crosses or toes
    Given game
    When when three crosses or toes filled mid column
    Then game returns signal
	Examples: game
	| |X| |
	| |X| |
	| |X| |
	or
	| |O| |
	| |O| |
	| |O| |