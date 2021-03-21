using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Triangle 
{
    private Vector2 pointA;

    public Vector2 PointA
    {
        get { return pointA; }
        set { pointA = value; }
    }

    private Vector2 pointB;

    public Vector2 PointB
    {
        get { return pointB; }
        set { pointB = value; }
    }

    private Vector2 pointC;

    public Vector2 PointC
    {
        get { return pointC; }
        set { pointC = value; }
    }

    private double sideAB;

    public double SideAB
    {
        get { return sideAB; }
        set { sideAB = value; }
    }

    private double sideBC;

    public double SideBC
    {
        get { return sideBC; }
        set { sideBC = value; }
    }

    private double sideCA;

    public double SideCA
    {
        get { return sideCA; }
        set { sideCA = value; }
    }

    private double perimeter;

    public double Perimeter
    {
        get { return perimeter; }
        set { perimeter = value; }
    }

    private double area;

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }


    public Triangle(Vector2 pointA, Vector2 pointB, Vector2 pointC)
    {
        PointA = pointA;
        PointB = pointB;
        PointC = pointC;
        sideAB = calculateSideDistance(pointA, pointB);
        sideBC = calculateSideDistance(pointB, pointC);
        sideCA = calculateSideDistance(pointC, pointA);
        Perimeter = calculatePerimeter(SideAB, SideBC, SideCA);
        Area = calculateArea(SideAB,SideBC,SideCA);
        Type = calculateType(SideAB,SideBC,SideCA);
    }

    public Triangle(Vector2 pointA, Vector2 pointB, Vector2 pointC, double sideA, double sideB, double sideC, double perimeter, double area) : this(pointA, pointB, pointC)
    {
        SideAB = sideA;
        SideBC = sideB;
        SideCA = sideC;
        Perimeter = perimeter;
        Area = area;
    }

    public Triangle(Vector2 pointA, Vector2 pointB, Vector2 pointC, double perimeter, double area) : this(pointA, pointB, pointC)
    {
        Perimeter = perimeter;
        Area = area;
    }

    private double calculateSideDistance(Vector2 sideOne, Vector2 sideTwo)
    {
        double answer;
        answer = Vector2.Distance(sideOne, sideTwo);
        return answer;
    }

    private double calculatePerimeter(double sideAB, double sideBC, double sideCA)
    {
        double answer;
        answer = sideAB + sideBC + sideCA;
        return answer;
    }

    private double calculateArea(double sideAB, double sideBC, double sideCA)
    {
        double answer;
        double semiperimeter = calculatePerimeter(sideAB,sideBC,sideCA) / 2;
        answer = Math.Sqrt(semiperimeter*((semiperimeter-sideAB)*(semiperimeter-sideBC)*(semiperimeter-sideBC)));
        return answer;         
    }

    private string calculateType(double sideAB, double sideBC, double sideCA)
    {
        string answer;
        double roundedAB = Math.Round(sideAB, 2);
        double roundedBC = Math.Round(sideBC, 2);
        double roundedCA = Math.Round(sideCA, 2);
        if (roundedAB == roundedBC && roundedBC == roundedCA)
        {
            answer = "Equilatero";
        }
        else if (roundedAB == roundedBC || roundedAB == roundedCA || roundedBC == roundedCA)
        {
            answer = "Isóceles";
        } else
        {
            answer = "Escaleno";
        }
        /*Debug.Log("Redondeado " + roundedAB);
        Debug.Log("Redondeado " + roundedBC);
        Debug.Log("Redondeado " + roundedCA);
        Debug.Log(sideAB);
        Debug.Log(sideBC);
        Debug.Log(sideCA);
        Debug.Log(Mathf.Approximately((float)sideAB, (float)sideBC));
        Debug.Log(Mathf.Approximately((float)sideBC, (float)sideCA));
        Debug.Log(Mathf.Approximately((float)sideCA, (float)sideAB));
        */
        return answer;
    }
}
