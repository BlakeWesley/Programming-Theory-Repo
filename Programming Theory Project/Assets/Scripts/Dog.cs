using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal
{
    // Inherit from Parent Class (Inheritance)
    // Resetting certain variables in the Parent class (Polymorphism)
    void Start()
    {
        MoveSpeed = 20.0f; // Increased movement speed
        ReverseSpeed = 2.0f; // Increased reverse speed
        // Jumpforce remains the same as mammal parent class

    }

}
