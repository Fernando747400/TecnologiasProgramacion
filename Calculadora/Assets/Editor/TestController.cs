using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TestController 
{
  [Test]

   public void typeOfTriangleTest()
    {
        Vector2 sideA = new Vector2(0f,12.3923f);
        Vector2 sideB = new Vector2(-6f, 2f);
        Vector2 sideC = new Vector2(6f, 2f);
        var Triangle = new Triangle(sideA,sideB,sideC);
        var typeExpected = "Equilatero";

        var typeReceived = Triangle.Type;

        Assert.That(typeExpected, Is.EqualTo(typeReceived));
    }
}
