# Depth First Graph Traversal
This app is able to take a graph and display a list of nodes collected by depth first, pre-order traversal from a starting root node.

## Challenge
Create a method that accepts an adjacency list as a graph, and conducts a depth first traversal. Without utilizing any of the built-in methods available to your language, return a collection of nodes in their pre-order depth-first traversal order.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n^2)

My approach uses a list to collect the nodes in the proper order, along with a helper method which takes in the list and a root node to begin the traversal using recursion. The list is populated in pre-order after each recursion until it finally returns a completed node list.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/DepthFirstGraph/Assets/depthFirst.jpg)
