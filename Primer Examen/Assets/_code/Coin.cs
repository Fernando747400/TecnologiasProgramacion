using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Circle
{
    //Attributes
    private string worth;
    private bool active;
    private float multiplier;

    public Coin()
    {

    }

    public Coin(int aVertices, double aRadius, string aWorth, bool isActive, float aMultiplier)
    {
        Vertices = aVertices;
        Radius = aRadius;
        worth = aWorth;
        active = isActive;
        multiplier = aMultiplier;
    }

    //Getter and setter
    public string Worth
    {
        set { worth = value; }
        get { return worth; }
    }

    public bool Active
    {
        set { active = value; }
        get { return active; }
    }

    public float Multiplier
    {
        set { multiplier = value; }
        get { return multiplier; }
    }

}
