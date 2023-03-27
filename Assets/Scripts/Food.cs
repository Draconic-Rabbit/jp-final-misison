using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] string _specificName;
    [SerializeField] string _colorName;
    [SerializeField] TextMeshProUGUI _txtUI;

    // ENCAPSULATION
    public string ColorName { get => _colorName; protected set => _colorName = value; }
    public string SpecificName { get => _specificName; protected set => _specificName = value; }

    // ABSTRACTION 
    public virtual void DisplayText()
    {
        _txtUI.text = GetDisplayedText();
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected virtual string GetDisplayedText()
    {
        return "I am some food. My name is " + _specificName + ". And i'm " + _colorName;
    }
}
