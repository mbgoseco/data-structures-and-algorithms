# Hashmap LEFT JOIN
This app demonstrates a Left Join operation on two hashmaps. In our example, two hashmaps of string key/values are joined in a new collection of all the first hashmap's keys and values, plus any values from the second hashmap that have the same key as the first.

## Challenge
* Write a function that LEFT JOINs two hashmaps into a single data structure.
* The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
* The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
* Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
* LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.
* The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.
* Avoid utilizing any of the library methods available to your language.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n)

To begin with the end, the result of this method returns as a list of arrays. A for loop is used to iterate through the first hashmap. When it reaches an index that isn't null, it then traverses the linked list of that index. At each node an array instance is created that is populated with the node's key, value, and for the last index, the result of a check if the node's key exists in the second hashmap, which would be the value or null. That new array is added to the return list, and the iteration of the first hashmap continues, until finally returning the resulting list of arrays.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/LeftJoin/Assets/left_join.jpg)