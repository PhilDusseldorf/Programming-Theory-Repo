using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected string nickname;

    public abstract string MakeNoise(); // ABSTRACTION

    protected virtual void Eat() {
        Debug.Log("I eat everything!");
    }

    
}
