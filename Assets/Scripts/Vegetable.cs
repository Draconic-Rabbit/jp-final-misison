using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Vegetable : Food
{
    protected override string GetDisplayedText()
    {
        return "I am a vegetable. Do not trust fruits, they're lying about themselves.";
    }
}
