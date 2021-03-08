using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Circle
{
    //Attributes

    private float damage;
    private float speed;
    private float precision;

    public Bullet()
    {

    }

    public Bullet(int aVertices, double aRadius, float aDamge, float aSpeed, float aPrecision)
    {
        Vertices = aVertices;
        Radius = aRadius;
        damage = aDamge;
        speed = aSpeed;
        precision = aPrecision;
    }

    public float Damage
    {
        set { damage = value; }
        get { return damage; }
    }

    public float Speed
    {
        set { speed = value; }
        get { return speed; }
    }

    public float Precision
    {
        set { precision = value; }
        get { return precision; }
    }
}
