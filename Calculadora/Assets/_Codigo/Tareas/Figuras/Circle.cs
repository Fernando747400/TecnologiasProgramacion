using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle 
{
    private Vector2 center;

    public Vector2 Center
    {
        get { return center; }
        set { center = value; }
    }
    private float radius;

    public float Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(Vector2 center, float radius)
    {
        Center = center;
        Radius = radius;
    }

    public float getDiametter()
    {
        float answer;
        answer = Radius * 2;
        return answer;
    }

    public float getPerimeter()
    {
        float answer;
        answer = (2 * Mathf.PI * Radius);
        return answer;
    }

    public float getArea()
    {
        float answer;
        answer = (Mathf.PI * Mathf.Pow(Radius, 2));
        return answer;
    }
}
