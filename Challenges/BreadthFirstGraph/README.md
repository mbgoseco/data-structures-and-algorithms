# Breadth-First Traversal of a Graph
This app allows you to display an adjacency list of vertices in a graph, using breadth first traversal from a starting node and travelling to every neighboring node in order, without touching previously visited nodes.

## Challenge
Extend your graph object with a breadth-first traversal method that accepts a starting node. Without utilizing any of the built-in methods available to your language, return a collection of nodes in the order they were visited. Display the collection.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n^2)

Using breadth first traversal, the method instantiates a queue and begins by enqueuing the root node. A while loop maintains the traversal so long as the queue is not empty. Within the loop, a front node is defined as the next dequeued node, set as visited, and then added to the adjacency list. Then, a foreach loop iterates over every edge in the front node and enqueues it's neighboring node and also setting that node as visited. The while loop then repeats until the queue is empty, until finally returning the complete adjacency list.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/BreadthFirstGraph/Assets/breadth-first-graph.jpg)
