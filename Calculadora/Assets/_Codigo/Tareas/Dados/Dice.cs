using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice{

    // Atributes
    public int numberOfFaces;
    public int numberOfEdges;
    private string color;
    private string material;
    public float sizeX;
    public bool available = false;
    private float radius;

    // Constructors
    public Dice(int anumberOfFaces, int anumberOfEdges, string acolor, string amaterial)
    {
        numberOfFaces = anumberOfFaces;
        numberOfEdges = anumberOfEdges;
        color = acolor;
        material = amaterial;
    }

    public Dice(int anumberOfFaces)
    {
        numberOfFaces = anumberOfFaces;
    }

    public Dice()
    {

    }

    // Methods
    public virtual int throwDice(){
        int answer;
        answer = Random.Range(1, numberOfFaces + 1);
        return answer;
    }

    // Getters Setters Properties
    public int NumberOfFaces
    {
        set
        {
            if (value < 3)
            {
                numberOfFaces = 3;
            }
            else
            {
                numberOfFaces = value;
            }
        }
        get { return numberOfFaces; }   
    }

    public int NumberOfEdges
    {
        set { value = numberOfEdges; }
        get { return numberOfEdges; }       
    }

    public string Color
    {
        set
        {
            if (value == "green" | value == "red")
            {
                color = value;
            }
            else
            {
                color = "NA";
            }
        }
        get { return color; }
    }

    public string Material
    {
        set { value = material; }
        get { return material; }
    }

    public float SizeX
    {
        set { value = sizeX; }
        get { return sizeX; }
    }

    public bool Available
    {
        set { value = available; }
        get { return available; }
    }

    public float Radius
    {
        set { value = radius; }
        get { return radius; }
    }

}

