using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle 
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    private float weight;

    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    private double area;

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    public Vehicle()
    {

    }

    public Vehicle(int weight)
    {
        Weight = weight;
    }

    public Vehicle(double area)
    {
        Area = area;
    }

    public Vehicle(string color, float weight, double height, double area)
    {
        Color = color;
        Weight = weight;
        Height = height;
        Area = area;
    }

}
