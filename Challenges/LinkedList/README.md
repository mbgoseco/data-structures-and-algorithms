# Singly Linked List
A short app designed to demonstrate the instantiation of linked lists and their properties.

## Challenge
Create a Node class that has properties for the value stored in the Node, and a reference to the next Node. Create a LinkedList class that has a propery for Head, a methods to instantiate new nodes, a method to check if a value exists on a node, and a method to print the linked list values to the console.

## Approach & Efficiency
Big O Time = O(1) \n
Big O Space = O(n)
New nodes are added and values assigned in one method call at O(i) time to linked list of O(n) space. Linked list is searched and displayed at O(n) time.

## API
Insert(int value) - Takes in an integer and creates a new node instance and assigns it the value of that integer. Also assigns its Next property to the last node, and assigns Head to the newest node.

Includes(int value) - Given an integer, it determines whether or not the number exists as a value in the linked list. Returns true or false.

Print() - Prints the values of the entire linked list to the console.
