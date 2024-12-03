using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    // Start
    private void Start()
    {
        DisplayName();
        MakeSound();
        Debug.Log($"{animalName} is weekly food requirement: {CalculateFoodRequirement()} k.g");
    }


    // Method
    public void Init(string animalName)
    {
        this.animalName = animalName;
    }

    public void DisplayName()
    {
        Debug.Log($"This is a {animalName}.");

    }

    // Virtual
    public virtual void MakeSound()
    {
        Debug.Log("The animal makes a sound.");
    }

    // Abstract
    public abstract float CalculateFoodRequirement();
}
