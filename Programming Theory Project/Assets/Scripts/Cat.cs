using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Mammal
{
    // Inherit from Parent Class (Inheritance)
    // Resetting certain variables in the Parent class (Polymorphism)
    void Start()
    {
        MoveSpeed = 10.0f; // Move speed increased
        ReverseSpeed = 2.0f; // Reverse speed increased
        JumpForce = 10.0f; // Jumpforce increased

    }

}
