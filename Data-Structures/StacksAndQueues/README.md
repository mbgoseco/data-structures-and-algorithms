# Stacks and Queues
An app designed to instantiate nodes within stack and queue data structures.

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
- Create a Stack class that has a top property. It creates an empty Stack when instantiated.
- This object should be aware of a default empty value assigned to top when the stack is created.
- Define a method called push which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
- Define a method called pop that does not take any argument, removes the node from the top of the stack, and returns the node’s value.
- Define a method called peek that does not take an argument and returns the value of the node located on the top of the stack.
- Create a Queue class that has a top property. It creates an empty queue when instantiated.
- This object should be aware of a default empty value assigned to front when the queue is created.
- Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
- Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
- Define a method called peek that does not take an argument and returns the value of the node located in the front of the stack.

## Approach & Efficiency
- Access/Search: Big O Time = O(n), - Big O Space = O(n)
- Insert/Delete: Big O Time = O(1), - Big O Space = O(n)
- New stacks, queues, and nodes are added and values are assigned in one method call at O(1) time to stack or queue of O(n) space. Stacks and queues are searched and displayed at O(n) time accross O(n) space of the data structure.

## API
- Stack.Push(int value) - Creates a new node and puts it at the top of the stack.
- Stack.Pop() - Creates a temp node, sets Top to the next node in the stack, clears the reference of Next on temp, and returns the temp node's Value.
- Stack.Peek() - Shows the value of the top node on the stack.
- Queue.Enqueue(int value) - Creates a new node and sets it at the end of the queue.
- Queue.Dequeue() - Removes the node at the front of the queue and returns its value.
- Queue.Peek() - Returns the node value at the front of the queue.