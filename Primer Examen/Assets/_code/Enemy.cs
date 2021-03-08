using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Coin
{
    //Attributes

    private float health;
    private float damage;
    private float strength;

    public Enemy()
    {

    }

    public Enemy(int aVertices, double aRadius, float aHealth, float aDamge, float aStrength)
    {
        Vertices = aVertices;
        Radius = aRadius;
        health = aHealth;
        damage = aDamge;
        strength = aStrength;
    }

    public float Health
    {
        set { health = value; }
        get { return health; }
    }

    public float Damage
    {
        set { damage = value; }
        get { return damage; }
    }

    public float Strength
    {
        set { strength = value; }
        get { return strength; }
    }
}
