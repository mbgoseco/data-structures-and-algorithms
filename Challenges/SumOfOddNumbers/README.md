# Sum of Odd Nodes
This app uses a method which takes in a binary tree and returns the sum of all of its odd valued nodes.

## Challenge
- Write a method to find the sum of all the odd numbers in a binary search tree.

## Approach & Efficiency
- Big O Space = O(w)
- Big O Time = O(n)
This method uses a queue based data structure which enqueues the root node, then a while loop which traverses the binary tree so long as the queue is not empty. In this case, the queue will only finally be empty after reaching and deqeueing the last leaf. As each node is enqueued, it is dequeued and assigned to a Front node, then it's value is evaluated to determine if it's odd, and if so, adds it to a sum total which is then returned after the tree is fully traversed.
