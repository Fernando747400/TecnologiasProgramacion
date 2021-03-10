using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle 
{
    //Attributes
    private int vertices;
    private double smallSide;
    private double bigSide;

    public Rectangle()
    {

    }

    public Rectangle(int aVertices, double aSmallSide, double aBigSide)
    {
        vertices = aVertices;
        smallSide = aSmallSide;
        bigSide = aBigSide;
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

    public double SmallSide
    {
        set { smallSide = value; }
        get { return smallSide; }
    }

    public double BigSide
    {
        set { if (value < smallSide)
            {
                bigSide = smallSide + 0.1;
            }
            else bigSide = value;
        }
        get { return bigSide; }
    }
}
