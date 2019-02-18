# Hashtables
This app features the manually built framework for a hashtable data structure and linked list chaining for handling collisions, demonstrating is usefulness in storing key/value pairs, and effeciently searching for them. It allows for the ability to instantiate a hashtable, create a key/value pair as a node, create a hash value for a key, and add the pair to the hash table. The hashtable can then be searched with a key to determine if they key exists and return the paired value if it does. 

## Challenge
Implement a Hashtable with the following methods:
* add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
* get: takes in the key and returns the value from the table.
* contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
* hash: takes in an arbitrary key and returns an index in the collection.

## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n) (Average O(1))
The approach I took had me first build out a new linked list and node structure to contain properties for both key and value values. From there I built the hashtable class to instantate a linked list array of 100 size for each hashtable instance. Hash values are built based on the unicode values of the key string, multiplied by 103 then moduloed by 100 (the range of the array). Adding a new key/value pair creates a node of their properties, gets a hash for the index, and adds the node to the linked list matching the hashtable's index. Searching for a key begins the same in getting a hash index from the key, then travesres the linked list at that index to find a matching key.

## API
Hash(string key)
* Converts a given key to an integer value based on the unicode sum of its characters, passed into a mathematical formula, which is then used as an index to assign the key/value pair in the hash table. The hash algorithm is designed to crate adequate dispersal of pairs across the array to avoid collision.

Add(string key, string value)
* Takes in a key/value pair, creates a hash value out of the key, and inserts the pair as a node into a linked list in the hash table at the index matching the hash value.

Contains(string key)
* Takes in a key string, creates a hash value from it, goes to the index of the hashtable matching the hash value, and traverses the linked list for a matching key. Returns true if a matching key is  found, false it not.

Get(string key)
* Takes in a key string, creates a hash value from it, goes to the index of the hashtable matching the hash value, and traverses the linked list for a matching key. Returns the value paired to that key if found.
