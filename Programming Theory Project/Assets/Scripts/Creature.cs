using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected string nickname;
    protected int health;
    protected int speed;
    protected int strength;

    protected Creature(string nickname, int health, int speed, int strength) {
        this.nickname = nickname;
        this.health = health;
        this.speed = speed;
        this.strength = strength;
    }

    protected abstract void Locomotion();

    protected abstract void Fight();

    
}
