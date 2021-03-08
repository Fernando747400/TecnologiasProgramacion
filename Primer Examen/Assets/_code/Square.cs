using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square 
{
    //Attributes
    private int vertices;
    private double size;

    //Contructor

    public Square()
    {

    }

    public Square(int aVertices, double aSize)
    {
        vertices = aVertices;
        size = aSize;
    }

    //Getter and setter

    public int Vertices
    {
        set
        {
            if (value != 4)
            {
                vertices = 4;
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
