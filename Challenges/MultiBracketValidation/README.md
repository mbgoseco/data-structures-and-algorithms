# Multi-bracket Validation.
This app takes in a string containing different types of brackets "({[]})" and determines if they are perfectly balanced, as all things should be.

## Challenge
Create a method called "public static bool MultiBracketValidation(string input)". The method should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:
- Round Brackets : ()
- Square Brackets : []
- Curly Brackets : {}

## Approach & Efficiency
Big O Time = O(n)
Big O Space = O(n)
- The method creates both an array and a stack which must be iterated over based on the size of input string and the number of brackets respecively. Thus, Big O time and space are both O(n).

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/MultiBracketValidation/assets/multi-bracket-validation.JPG)
