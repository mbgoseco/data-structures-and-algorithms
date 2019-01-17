# LList_Merge
An project extending the functionality of the Linked List app to include a method to zipper merge two linked lists together and return one.

## Challenge
Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
- Big O Time = O(n) - The method will traverse at least the shortest list length before returning a result.
- Big O Space = O(1) - No new linked lists are created for the method, only two new nodes to contain old node references before they are reassigned.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/LinkedList-KthFromEnd/assets/ll_kth_from_end.jpeg)

