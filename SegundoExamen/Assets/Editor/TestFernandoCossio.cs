using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;
public class TestFernandoCossio 
{
    [UnityTest]

    public IEnumerator enemyAmbushTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemy = new Enemy();
        Hero myHero = new Hero();

        //Act
        myEnemy.createFoolEnemy(level);
        myHero.createTankHero(level);
        myEnemy.Speed = 5;
        myHero.Speed = 2;
        myBattle.EnemyAmbush(myEnemy, myHero);
        yield return null;
        //Assert
        Assert.That(myHero.LifePoints, Is.InRange(-1150, 100));
    }

    [UnityTest]

    public IEnumerator magicAttackTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemy = new Enemy();
        Hero myHero = new Hero();

        //Act
        myEnemy.createFoolEnemy(level);
        myHero.createTankHero(level);
        myEnemy.Speed = 5;
        myHero.Speed = 2;
        myBattle.MagicAttack(myEnemy, myHero);
        yield return null;
        //Assert
        Assert.That(myHero.LifePoints, Is.InRange(-25, 150));
    }

    [UnityTest]

    public IEnumerator counterAttackTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemy = new Enemy();
        Hero myHero = new Hero();

        //Act
        myEnemy.createFoolEnemy(level);
        myHero.createTankHero(level);
        myBattle.CounterAttack(myEnemy, myHero);
        yield return null;
        //Assert
        Assert.That(myEnemy.LifePoints, Is.InRange(0, 75));
    }

    [UnityTest]

    public IEnumerator unitedAttackTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemy = new Enemy();
        Hero myHeroOne = new Hero();
        Hero myHeroTwo = new Hero();
        Hero myHeroThree = new Hero();

        //Act
        myEnemy.createFoolEnemy(level);
        myHeroOne.createTankHero(level);
        myHeroTwo.createTankHero(level);
        myHeroThree.createTankHero(level);
        myBattle.UnitedAttack(myEnemy, myHeroOne, myHeroTwo,myHeroThree);
        yield return null;
        //Assert
        Assert.That(myEnemy.LifePoints, Is.InRange(0, 25));
    }

    [UnityTest]

    public IEnumerator defendFromEnemyTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemy = new Enemy();
        Hero myHero = new Hero();

        //Act
        myEnemy.createFoolEnemy(level);
        myHero.createTankHero(level);
        myBattle.DefendFromEnemy(myEnemy, myHero);
        yield return null;
        //Assert
        Assert.That(myHero.LifePoints, Is.InRange(50, 100));
    }

    [UnityTest]

    public IEnumerator escapeFromEnemiesTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemyOne = new Enemy();
        Enemy myEnemyTwo = new Enemy();
        Hero myHeroOne = new Hero();
        Hero myHeroTwo = new Hero();
        Hero myHeroThree = new Hero();

        //Act
        myEnemyOne.createFoolEnemy(level);
        myEnemyTwo.createFoolEnemy(level);
        myHeroOne.createTankHero(level);
        myHeroTwo.createTankHero(level);
        myHeroThree.createTankHero(level);
        myEnemyOne.Speed = 2;
        myEnemyTwo.Speed = 3;
        myHeroOne.Speed = 2;
        myHeroTwo.Speed = 1;
        myHeroThree.Speed = 1;
        var myAnswer = myBattle.EscapeFromEnemies(myEnemyOne, myEnemyTwo, myHeroOne, myHeroTwo, myHeroThree);
        yield return null;
        //Assert
        Assert.That(myAnswer, Is.True);

    }

    [UnityTest]

    public IEnumerator getExperienceTest()
    {
        //Arrange
        var gameObject = new GameObject();
        var myBattle = gameObject.AddComponent<BattleController>();
        var level = 25;
        Enemy myEnemyOne = new Enemy();
        Hero myHeroOne = new Hero();
        Hero myHeroTwo = new Hero();
        Hero myHeroThree = new Hero();

        //Act
        myEnemyOne.createFoolEnemy(level);
        myHeroOne.createTankHero(level);
        myHeroTwo.createTankHero(level);
        myHeroThree.createTankHero(level);
        myBattle.GetExperience(myEnemyOne, myHeroOne, myHeroTwo, myHeroThree);
        yield return null;
        //Assert
        Assert.That(myHeroOne.Experience, Is.InRange(0,8.4));
    }
}
