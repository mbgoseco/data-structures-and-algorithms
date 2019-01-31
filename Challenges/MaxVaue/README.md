# Find the Maximum Value in a Binary Tree
This app finds the greatest integer node value in a given binary tree. The method designed in this program will recursively traverse the array, comparing node values as it returns, and then output the highest value.

## Challenge
- Write a function called find-maximum-value which takes binary tree as its only input. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Approach & Efficiency
- Big O Space = O(h)
- Big O Time = O(n)
This method uses a recursive approach to traverse the array. Before this happens however, it defines a max int value as the lowest possible int value. It then checks if the starting root is null and returns max if true, or sets max as the root value if false. Traversal begins as a variable is assigned to the return value of the recursive call of FindMaxValue() on the left child, and a variable for the recursive call of the right child. The node values are compared to the max as each return is made from a leaf node, until it finally reaches the last node and returns the max value.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/MaxVaue/assets/find-maximum-value-binary-tree.jpg)
