using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : Coin
{
    //Attributes

    private float health;
    private float damage;
    private bool isAlive;

    public Companion()
    {

    }

    public Companion(int aVertices, double aRadius, float aHealth, float aDamge, bool aIsAlive)
    {
        Vertices = aVertices;
        Radius = aRadius;
        health = aHealth;
        damage = aDamge;
        isAlive = aIsAlive;
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

    public bool IsAlive
    {
        set { isAlive = value; }
        get { return isAlive; }
    }
}
