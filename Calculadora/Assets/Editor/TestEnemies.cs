using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TestEnemies 
{
    [Test]

    public void supportLifeTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.LifePoints, Is.InRange(25,37));
    }

    [Test]

    public void supportMagicTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.MagicPoints, Is.InRange(51, 75));
    }

    [Test]

    public void supportStaminaTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Stamina, Is.LessThanOrEqualTo(24));
    }

    [Test]

    public void supportSpeedTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Speed, Is.LessThanOrEqualTo(24));
    }

    [Test]

    public void supportDefenseTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Defense, Is.GreaterThanOrEqualTo(0));
    }

    [Test]

    public void supportAttackTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Attack, Is.GreaterThanOrEqualTo(-24));
    }

    [Test]

    public void supportLuckyTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Lucky, Is.AtMost(120));
    }

    [Test]

    public void supportLiveTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Live, Is.True);
    }

    [Test]

    public void supportExperienceTest()
    {
        //Arrange
        Enemy support = new Enemy();
        var level = 25;

        //Act
        support.createSupportEnemy(level);

        //Assert
        Assert.That(support.Experience, Is.EqualTo(0));
    }
}
