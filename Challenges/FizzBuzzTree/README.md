# FizzBuzz Tree
This app contains a method which takes in a binary tree and changes any nodes divisible by 3 to "Fizz", nodes divisible by 5 to "Buzz", and nodes divisible by 15 to "FizzBuzz".

## Challenge
- Write a function called FizzBuzzTree which takes a tree as an argument.
- Without utilizing any of the built-in methods available to your language, determine weather or not the value of each node is divisible by 3, 5 or both, and change the value of each of the nodes:
If the value is divisible by 3, replace the value with “Fizz”
If the value is divisible by 5, replace the value with “Buzz”
If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
- Return the tree with its new values.

- For explicitly-typed languages: Ensure your node values are of type Object, to hold either strings or integers.

## Approach & Efficiency
Big O Time = O(n)
Big O Space = O(H)
- The method traverses a given binary tree recursively, comparing each node value to the FizzBuzz conditions then storing that value to a List before moving to the next node. After traversal is finished the List is converted to an array before being returned.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/FizzBuzzTree/assets/FizzBuzzTree.JPG)