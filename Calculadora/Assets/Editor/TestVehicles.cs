using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

public class TestVehicles 
{
    [UnityTest]

    public IEnumerator firstRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(0, 1);

        yield return null;
        //Assert
        Assert.That(winningCar.Name, Is.EqualTo("Buggati Veyron"));
    }

    [UnityTest]

    public IEnumerator secondRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(3, 4);

        yield return null;
        //Assert
        Assert.That(winningCar.TopSpeed, Is.EqualTo(315));
    }

    [UnityTest]

    public IEnumerator thirdRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(8, 9);

        yield return null;
        //Assert
        Assert.That(winningCar.Color, Is.EqualTo("Azul"));
    }

    [UnityTest]

    public IEnumerator fourthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(4, 1);

        yield return null;
        //Assert
        Assert.That(winningCar.Weight, Is.EqualTo(1990));
    }

    [UnityTest]

    public IEnumerator fifthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(9, 1);

        yield return null;
        //Assert
        Assert.That(winningCar.Height, Is.EqualTo(1.20));
    }

    [UnityTest]

    public IEnumerator sixthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(3, 8);

        yield return null;
        //Assert
        Assert.That(winningCar.Doors, Is.EqualTo(2));
    }

    [UnityTest]

    public IEnumerator seventhRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(2, 0);

        yield return null;
        //Assert
        Assert.That(winningCar.Name, Is.EqualTo("Ferrari Enzo"));
    }

    [UnityTest]

    public IEnumerator eighthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(6, 2);

        yield return null;
        //Assert
        Assert.That(winningCar.Name, Is.EqualTo("Lamborghini Aventador"));
    }

    [UnityTest]

    public IEnumerator ninthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(5, 6);

        yield return null;
        //Assert
        Assert.That(winningCar.Cylinders, Is.EqualTo(8));
    }

    [UnityTest]

    public IEnumerator tenthRaceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var racing = gameObject.AddComponent<RaceController>();

        //Act
        var winningCar = racing.raceTest(7, 4);

        yield return null;
        //Assert
        Assert.That(winningCar.Color, Is.EqualTo("Blanco"));
    }
}
