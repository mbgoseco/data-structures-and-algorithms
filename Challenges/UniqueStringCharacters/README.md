# Unique String Characters
This app compares all of the characters in a given string to each other and determines if they are unique.

## Challenge
Implement a method with the following signature bool AreCharactersUnique(string input) that returns true if all the characters in the string are unique.

## Approach & Efficiency
The method uses a for loop which iterates the length of the string, and a nested for loop which iterates from the position of the outer for loop onwards. The inner loop compares its character element in the string to the character element of the outer loop to determine if they are equal, and returns false if so. If the nested for loops complete without ever returning false, then the characters are unique and returns true.
- Big O Time: O(n^2)
- Big O Space: O(1)

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/UniqueStringCharacters/Assets/UniqueStringCharacters.jpg)
