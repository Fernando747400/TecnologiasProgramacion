using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle 
{
    //Attributes

    private int vertices;
    private double radius;

    //Constructros
    public Circle()
    {

    }

    public Circle(int aVertices, double aRadius)
    {
        vertices = aVertices;
        radius = aRadius;
    }

    //Getter and setter

    public int Vertices
    {
        set {
            if (value < 0)
            {
                vertices = 0;
            }
            else vertices = value;
                }
        get { return vertices; }
    }

    public double Radius
    {
        set { radius = value; }
        get { return radius; }
    }
}
