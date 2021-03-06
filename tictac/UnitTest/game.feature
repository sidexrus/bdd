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

  Scenario Outline: The right column consists of three crosses or toes
    Given game
    When when three crosses or toes filled right column
    Then game returns signal
	Examples: game
	| | |X|
	| | |X|
	| | |X|
	or
	| | |O|
	| | |O|
	| | |O|

  Scenario Outline: The mid line consists of three crosses or toes
    Given game
    When when three crosses or toes filled mid line
    Then game returns signal
	Examples: game
	| | | |
	|X|X|X|
	| | | |
	or
	| | | |
	|O|O|O|
	| | | |

  Scenario Outline: The bottom line consists of three crosses or toes
    Given game
    When when three crosses or toes filled bottom line
    Then game returns signal
	Examples: game
	| | | |
	| | | |
	|X|X|X|
	or
	| | | |
	| | | |
	|O|O|O|

  Scenario Outline: The first diagonal consists of three crosses or toes
    Given game
    When when three crosses or toes filled first diagonal
    Then game returns signal
	Examples: game
	|X| | |
	| |X| |
	| | |X|
	or
	|O| | |
	| |O| |
	| | |O|

  Scenario Outline: The second diagonal consists of three crosses or toes
    Given game
    When when three crosses or toes filled second diagonal
    Then game returns signal
	Examples: game
	| | |X|
	| |X| |
	|X| | |
	or
	| | |O|
	| |O| |
	|O| | |

  Scenario Outline: Draw
    Given game
    When draw
    Then game returns signal
	Examples: game

