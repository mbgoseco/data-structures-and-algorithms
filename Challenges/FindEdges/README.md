# Find Edges
By taking in a graph of city nodes and a string array of city names, this app will determine if a direct path can be found between all nodes in the sequence of the array, and if so, it will also determine the sum of the cost between each node.

## Challenge
Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n^2)

The method contains a boolean to represent if a complete path is found, and an int for the cost set to 0. This approach uses a nested for loop of sorts that begins with a for loop iterating through the array of city names. Within that loop, we use the GetNeighbors method previously built in the Graph class to get a list of all edges of the node matching the current array element. We then check that list of edges to see if a neighbor node exists with a name matching the element ahead in the array. If there is no match, the method returns a tuple of false and 0, representing the result of finding a complete path and cost. If an edge with a matching neighbor is found, the path boolean is set to true and the weight of that edge is added to the total cost. If the for loop finishes then a complete path has been found and the method returns a tuple of the path boolean and the total cost.

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/FindEdges/Assets/get-edges.jpg)
