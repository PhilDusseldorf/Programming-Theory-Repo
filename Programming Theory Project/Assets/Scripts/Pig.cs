using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : Creature
{
    public Pig() {

    }

    public Pig(string nickname) {
        this.nickname = nickname;
    }
    
    public override string MakeNoise() {
        return "Oink! Oink!";
    }

}
