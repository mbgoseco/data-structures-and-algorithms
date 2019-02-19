# First repeated word
Through use of the hash table data structure, this app finds the first word that occurs more than once in a given string, no matter the size.

## Challenge
* Write a function that accepts a lengthy string parameter.
* Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n)  (Average O(1))

The approach to this method begins by splitting the words into an array of strings, using the spaces between as the delimiter. Afterwards, this array is iterated through, and at each index checks what begins as an empty hash table if the word at the current index is contained in the hash table. If it is then that word is returned. If not, then that word is added to the hash table and the iteration continues. If no repeating word is found, then the method returns null.

## Solution
![whiteboard]()
