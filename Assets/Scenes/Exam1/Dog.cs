using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailiyFoodConsumption;
    private int activityLevel;

    private void Awake()
    {
        Init("Dog");
        dailiyFoodConsumption = 0.5f;
        activityLevel = 3;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} barks: Woof Woof.");
    }

    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName} eats {dailiyFoodConsumption} kg of food daily with activity level {activityLevel}.");
        return dailiyFoodConsumption * activityLevel * 7f;
    }

}
