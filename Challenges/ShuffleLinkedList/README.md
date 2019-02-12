# Shuffle Linked List
This app utilizes a method that takes in a linked list and randomly shuffles the nodes within it.

## Challenge
Implement a method with the following signature LinkedList ShuffleLinkedList(LinkedLst list) that re-arranges the nodes of the linked list in a random order. The modifications must happen in-place (i.e. avoid making a copy of the linked list)

## Approach & Efficiency
The design of the method first traverses the entire list to measure its length. This length will be used as the upper boundary for the random number generator. It then begins a for loop for the node swapping process, and repeats a number of times equal to the length of the list. Within the loop, the random number is created for each iteration. This represents the number of steps down the list to traverse before swapping the head position with the current step position. Once the swap is complete the for loop repeats the process.
- Big O Time = O(n)
- Big O Space = O(1)

## Solution
![whiteboard]()
