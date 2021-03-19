using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDetailed : Vehicle
{
    private int doors;

    public int Doors
    {
        get { return doors; }
        set { doors = value; }
    }

    private int passenger;

    public int Passenger
    {
        get { return passenger; }
        set { passenger = value; }
    }
    private int cylinders;

    public int Cylinders
    {
        get { return cylinders; }
        set { cylinders = value; }
    }

    private double gasoline;

    public double Gasoline
    {
        get { return gasoline; }
        set { gasoline = value; }
    }

    private double topSpeed;

    public double TopSpeed
    {
        get { return topSpeed; }
        set { topSpeed = value; }
    }

    private int gearbox;

    public int Gearbox
    {
        get { return gearbox; }
        set { gearbox = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public VehicleDetailed(int doors, int passenger, int cylinders, double gasoline, double topSpeed, int gearbox, string name)
    {
        Doors = doors;
        Passenger = passenger;
        Cylinders = cylinders;
        Gasoline = gasoline;
        TopSpeed = topSpeed;
        Gearbox = gearbox;
        Name = name;
    }

    public VehicleDetailed(string color, float weight, double height, double area, int doors, int passenger, int cylinders, double gasoline, double topSpeed, int gearbox, string name)
    {
        Color = color;
        Weight = weight;
        Height = height;
        Area = area;
        Doors = doors;
        Passenger = passenger;
        Cylinders = cylinders;
        Gasoline = gasoline;
        TopSpeed = topSpeed;
        Gearbox = gearbox;
        Name = name;
    }


}
