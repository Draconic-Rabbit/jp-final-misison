using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Fruit : Food
{
    // POLYMORPHISM
    protected override string GetDisplayedText()
    {
        // ENCAPSULATION is at work in this next line
        return "I am a fruit. My name is " + SpecificName + ". And i'm better than vegetable. And i'm " + ColorName + ".";
    }
}
