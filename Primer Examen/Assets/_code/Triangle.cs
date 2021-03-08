using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle 
{
    //Attributes

    private int vertices;
    private double size;

    //Constructor
    public Triangle()
    {

    }

    public Triangle(int aVertices, double aSize)
    {
        vertices = aVertices;
        size = aSize;
    }

    //Getter and setter

    public int Vertices
    {
        set { if (value != 3)
                {
                    vertices = 3;
                }
                else vertices = value;
            }
        get { return vertices; }
    }

    public double Size
    {
        set { size = value; }
        get { return size; }
    }
}
