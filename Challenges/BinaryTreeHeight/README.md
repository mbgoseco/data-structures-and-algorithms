# Binary Tree Height
This app measures the height of a given binary tree, as well as the number of levels on the tree. Height is the number of edges from the root to the lowest path in a tree, while levels are represented by each layer of nodes in a tree.

## Challenge
Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) that calculates the height of a binary tree.

## Approach & Efficiency
The method uses recursion to travel the depth of the tree, adding 1 to a return sum as it progress past each edge. The final sum will return once all node leaves have been reached. Edge conditions are also considered in the case of a single node tree or an empty tree.
- Big O Time: O(n)
- Big O Space: O(h)

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/BinaryTreeHeight/Assets/BinaryTreeHeight.jpg)
