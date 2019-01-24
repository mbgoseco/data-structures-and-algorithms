using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;
using AnimalShelter.Classes;

namespace AnimalShelter.Classes
{
    public class Animal
    {
        public string Value { get; set; }
        public Animal Next { get; set; }

        public Animal(string value)
        {
            Value = value;
        }
    }
}
