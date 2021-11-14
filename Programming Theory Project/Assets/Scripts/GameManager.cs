using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CreateCreature(string option)
    {
        if (option == "walker")
        {
            Creature creature = new Walker("Peter", 10);
        } else {
            Creature creature = new Flyer("Birdy", 9);
        }
    }
}
