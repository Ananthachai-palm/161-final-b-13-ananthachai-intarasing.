using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("Spell_Casting Simulation Started!");
        Debug.Log("Casting a generic Spell!");
    }
    public void Cast(string input)
    {

    }
    public void Cast(string input, int inputint)
    {

    }
    

}
