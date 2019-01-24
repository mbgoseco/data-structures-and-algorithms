using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace AnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public AnimalShelter Queue { get; set; }

        public AnimalShelter(Animal node)
        {
            Queue = new AnimalShelter
            {
                Front = node,
                Rear = node
            };
        }

        public AnimalShelter()
        {

        }

        public void Enqueue(string value)
        {
            Animal animal = new Animal(value);
            Rear.Next = animal;
            Rear = animal;
        }

        public Animal Dequeue(Animal pref)
        {
            if (pref.Value.ToLower() != "cat" || pref.Value.ToLower() != "dog")
            {
                return null;
            }
            if (Queue.Front.Value == pref.Value)
            {
                Animal temp = Queue.Front;
                Queue.Front = Queue.Front.Next;
                temp.Next = null;
                return temp;
            }

            AnimalShelter tempQueue = new AnimalShelter();

            while (Queue.Front.Next != null)
            {
                if (Queue.Front.Value == pref.Value)
                {
                    Animal firstTemp = Queue.Front;
                    Queue.Front = Queue.Front.Next;
                    firstTemp.Next = null;
                    return firstTemp;
                }
                Animal temp = Queue.Front;
                Queue.Front = Queue.Front.Next;
                tempQueue.Enqueue(temp.Value);
            }
            if (Queue.Front.Value == pref.Value)
            {
                Animal firstTemp = Queue.Front;
                Queue.Front = Queue.Front.Next;
                firstTemp.Next = null;
                return firstTemp;
            }

            return null;
        }
    }
}
