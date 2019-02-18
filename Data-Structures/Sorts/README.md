# Insertion Sort
This app demonstrates the process behind an insertion sort algorithm. Here, a method is built to take in an array of integers and return them in ascending order. Also includes cases for a single element or empty array.

## Challenge
Write a method for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.

## Approach & Efficiency
* Big O Space = O(1)
* Big O Time = O(n^2)

The method iterates through the arrary using two variables to mark the first and next element. As it iterates, when the marked element in lead is less than the marked element behind, a while loop is triggered that begins to iterate backwards through the array, shifting the marked element on the left one place to the right, until the the original marked element that was the lesser is now greater than the next element travelling backwards, and places that marked value at the current index before finally continuing the forward iteration where it left off.
