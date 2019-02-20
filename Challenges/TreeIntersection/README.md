# Intersection of binary trees
Using a combination of Queues and Hash Tables, this app takes two separate binary trees and returns an array of all node values that exist in both trees.

## Challenge
* Write a method called TreeIntersection that takes two binary tree parameters.
* Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n)

The approach to this method begins by instantiating a hash table and adding all of the node values of the first binary tree to it, using breadth first traversal. Then the second tree is traversed the same way, but in this case, as each node is taken out the queue, a check is made to see if its value is also contained in the hash table. If it is, then the value is added to the list of results. Although Big O Space for this type of non-recursive traversal would normally be O(w), the hash table is still by far the bigger data set, so space is instead O(n). Time is O(n) also as this method avoids nested loops.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/TreeIntersection/Assets/tree_intersection.jpg)

