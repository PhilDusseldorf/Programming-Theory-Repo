using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Creature // INHERITANCE
{
    private int milkAmount {get {return milkAmount;} set {if (milkAmount<0 || milkAmount>20) {milkAmount = 20;}}}  // ENCAPSULATION
        
    public Cow() {}

    public Cow(string nickname, int milkAmount) { // POLYMORPHISM
        this.nickname = nickname;
        this.milkAmount = milkAmount;
    }
    
    public override string MakeNoise() { // POLYMORPHISM
        return "Moooooo!";
    }
    
    public void milk() {
        while(milkAmount>0) {
            milkAmount--;
            GameManager.Instance.milkCounter++;
        }
    }
}
