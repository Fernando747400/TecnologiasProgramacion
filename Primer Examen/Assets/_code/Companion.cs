using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : Coin
{
    //Attributes

    private float health;
    private float damage;
    private bool friendly;

    public Companion()
    {

    }

    public Companion(int aVertices, double aRadius, float aHealth, float aDamge, bool aFriendly)
    {
        Vertices = aVertices;
        Radius = aRadius;
        health = aHealth;
        damage = aDamge;
        friendly = aFriendly;
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

    public bool Friendly
    {
        set { friendly = value; }
        get { return friendly; }
    }
}
