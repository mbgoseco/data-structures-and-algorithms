# Singly Linked List
A short app designed to demonstrate the instantiation of linked lists and their properties.

## Challenge
Create a Node class that has properties for the value stored in the Node, and a reference to the next Node. Create a LinkedList class that has a propery for Head, a methods to instantiate new nodes, a method to check if a value exists on a node, and a method to print the linked list values to the console.

## Approach & Efficiency
- Big O Time = O(1)
- Big O Space = O(n)
- New nodes are added and values assigned in one method call at O(1) time to linked list of O(n) space. Linked list is searched and displayed at O(n) time, using O(1) space in variables to traverse.

## API
- Insert(int value) - Takes in an integer and creates a new node instance with that value and assigns it to the Head of the linked list. 
- Includes(int value) - Given an integer, it determines whether or not the number exists as a value in the linked list. Returns true or false.
- Print() - Prints the values of the entire linked list to the console. If no nodes are present, it informs the user there is nothing to display.
- Append(int value) - Takes in an integer, creates a new node and assigns it that value, then appends it to the end of the linked list.
- InsertBefore(int value, int newValue) - Searches the linked list for a target node value and, if it finds it, creates a new node with newValue and inserts it before the targeted node.
- InsertAfter(int value, int newValue) - Searches the linked list for a target node value and, if it finds it, creates a new node with newValue and inserts it after the targeted node.