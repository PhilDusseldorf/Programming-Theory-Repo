using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : Creature
{
    protected Walker(string nickname, int health, int speed, int strength) 
    {
    this.nickname = nickname;
    this.health = health;
    this.speed = speed;
    this.strength = strength;
    }

    protected override void Fight() 
    {
        Debug.Log("Fight!");
    }

    protected override void Locomotion()
    {
        Debug.Log("Move on Ground!");
    }
}
