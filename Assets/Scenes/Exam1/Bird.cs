using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailiyFoodConsumption;
    private float weight;

    private void Awake()
    {
        Init("Bird");
        dailiyFoodConsumption = 0.1f;
        weight = 0.5f;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} chirps: Tweet Tweet.");
    }

    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName} eats {dailiyFoodConsumption} kg of food daily with weights {weight}.");
        return dailiyFoodConsumption * weight * 7f;
    }

}
