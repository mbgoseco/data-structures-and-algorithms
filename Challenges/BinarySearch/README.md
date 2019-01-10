# Binary Search
This app demonstrates the binary search algorithm through the use of a method that takes in a sorted array and a key value and attempts to find the key value in the array.

## Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
The method will find the middle element of the passed array and compare that element to the key value and return if there is a match. If not, it will determine if the key value is greater than or less than the current middle element. It will then repeat the process on that half of the array, targeting a new midpoint within that half to compare to the key value. This will continue repeating until either the key value matches the current midpoint element, or until the new midpoint index matches the start or end index, meaning it cannot bisect its search range again.
-Big O
-Space: O(1)
-Time: O(log n)

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/assets/array_binary_search.jpg)
