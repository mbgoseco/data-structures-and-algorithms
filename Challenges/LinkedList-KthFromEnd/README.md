# kth from the end of a Linked List
An project extending the functionality of the Linked List app to include a method to find the node value of a node at k places from the end of a linked list.

## Challenge
Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
- Big O Time = O(n) - The method must first traverse the entire list to measure the length, then loop again through it a fixed number of times for the length - k - 1, in order to find the correct node.
- Big O Space = O(1) - Aside from the list, the method needs only one new variable to measure the length of the list.

## Solution
![whiteboard]()
![screenshot]()