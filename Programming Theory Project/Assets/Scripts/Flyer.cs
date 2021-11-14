using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : Creature
{
    public Flyer(string nickname, int strength) 
    {
    this.nickname = nickname;
    this.strength = strength;
    Debug.Log("Flyer created");
    }

    protected override void Locomotion()
    {
        Debug.Log("I move in the air!");
    }

    protected override void Fight()
    {
        base.Fight();
        Debug.Log("And disappear in the sky.");
    }
}
