using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    public string nickname;
    protected int strength;

    protected abstract void Locomotion(); // ABSTRACTION

    protected virtual void Fight() {
        Debug.Log("I can fight!");
    }

    
}
