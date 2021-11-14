using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : Creature // INHERITANCE
{
    public Walker(string nickname, int strength) 
    {
    this.nickname = nickname;
    this.strength = strength;
    Debug.Log("Walker created");
    }

    protected override void Locomotion() // POLYMORPHISM
    {
        Debug.Log("I move on ground!");
    }
}
