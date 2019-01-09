# Insert and shift middle index of array
An app written in C# with a single method that takes in an array and an integer then creates a new array with the integer placed in the middle index.

## Challenge
Write a function called ArrayShift which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index. You may round up in the event that the array has an odd number of indexes.

## Approach & Efficiency
In our method we first assigned a midpoint of the new array to the length of the new array divided by 2 then minus 1. We the used a for loop to iterate through the new array, filling it with the elements of the old array EXCEPT in the case where the current index matched the midpoint value. In that case the middle element would be filled with the value of the integer value passed to the method for the middle index of the new array.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/assets/array_shift.jpg)
