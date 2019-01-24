# First-in, First out Animal Shelter.
This app teaches the ability to select nodes from a First In First Out style data structure through traversing a queue styled as an animal shelter that contains cats and dogs, and demonstrates how to select a given type of animal.

## Challenge
- Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

## Approach & Efficiency
- Enqueue - Big O Time = O(1), Space = O(1): This method simply creates a new animal node and assigns it a Front and Rear proprety of the queue. No traversal is needed so time and space is just O(1).
- Dequeue - Big O Time = O(n), Space = O(n): A temp value is created to store a potentially matching animal node, and a temp queue is created to move non matching nodes to the temp queue and then assign it back to the main queue, minus the matchingn node. Because traversal and a new queue is required, time and space are both O(n).

## Solution
![whiteboard](https://github.com/mbgoseco/data-structures-and-algorithms/blob/master/Challenges/AnimalShelter/assets/fifo_animal_shelter.JPG)
