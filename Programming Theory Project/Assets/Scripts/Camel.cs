using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camel : Mammal
{
    // Inherit from Parent Class (Inheritance)
    // Resetting certain variables in the Parent class (Polymorphism)
    void Start()
    {
        JumpForce = 2.0f; // Jump force decreased
        // Movespeed and reverse speed remain same as mammal parent class

    }

}
