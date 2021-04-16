using UnityEngine;
using System;

public class BattleController : MonoBehaviour {


    void Start()
    {
        // Inicialización de objetos
        Character generic = new Character("gen1", 10, 5, 2, 1, 2, 1, 0, 1);
        Debug.Log("El nombre del caracter es:  " + generic.Name);

        Enemy enemigo1 = new Enemy();
        enemigo1.Name = "ene1";
        Debug.Log("El nombre del enemigo es: " + enemigo1.Name);

        // Inicialización de objetos con constructor en clase Base: 
        // Se manda parámetro de constructor a la clase base para que se
        // Inicialice en la clase Character y no en Enemy
        Enemy enemigo2 = new Enemy("BaseEnemy");
        Debug.Log("El nombre del enemigo es: " + enemigo2.Name);
        enemigo2.createRandomStatus(10);
        Debug.Log("Los LifePoints del enemigo2 es: " + enemigo2.LifePoints);

        Enemy fool = new Enemy();
        fool.createFoolEnemy(5);
        Debug.Log("Este son los life points del fool enemy " + fool.LifePoints);

    }

    // A1 (3 PUNTOS)
    public void EnemyAmbush(Enemy enemy, Hero hero)
    {
        //Se modificó el código para evitar división entre 0. 
        if (hero.Speed != 0)
        {
            int ambush = (int)((enemy.Attack) * 2) * (enemy.Speed / hero.Speed); // 0 - 1250  
            hero.LifePoints -= ambush; // -1150 - 100
        } else
        {
            int ambush = (int)((enemy.Attack) * 2) * (enemy.Speed / 1);
            hero.LifePoints -= ambush;
        }

        //Mientras la vida de ambos sea mayor a 0 correrá el programa hasta que uno baje de 0.
        while(enemy.LifePoints>0 | hero.LifePoints > 0)
        {
            //Si la velocidad del enemigo es mayor o igual al del heroe, se le resta primero la vida al heroe 
            if(enemy.Speed >= hero.Speed)
            {
                hero.LifePoints -= Math.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense);
                enemy.LifePoints -= Math.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense);
            }
            //si el heroe tiene mayor velocidad, se le resta la vida al enemigo primero. 
            else
            {
                enemy.LifePoints -= Math.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense);
                hero.LifePoints -= Math.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense);
            }
            //Se modificó el código para evitar curación. 
        }
    }

    // A2 (2 PUNTOS)
    public void MagicAttack(Enemy enemy, Hero hero)
    {
        //Si el enemigo tiene mas velocidad con un minio de 5 de magia, aplica formula para descontar vida al heroe
        if(enemy.Speed >= hero.Speed && enemy.MagicPoints > 4)
        {
            hero.LifePoints -= Math.Abs((enemy.Attack)*2*enemy.criticalHit(enemy.Lucky) - hero.Defense); //-25 - 150
        }
        ///Si el heroe tiene mas velocidad con un minio de 5 de magia, aplica formula para descontar vida al enemigo
        else if (enemy.Speed < hero.Speed && hero.MagicPoints > 4)
        {
            enemy.LifePoints -= Math.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense);
        }
        //Se modificó el código para evitar curación.
    }

    // A3 (2 PUNTOS)
    public void CounterAttack(Enemy enemy, Hero hero)
    {
        if(hero.MagicPoints > 2)
        {            
            //Si el héroe tiene 3 o mas puntos de magia, el enemigo recibe daño según su propio valor de ataque. Despues resta 2 puntos de magia al heroe.
            enemy.LifePoints -= Math.Abs((int)((enemy.Attack)*hero.criticalHit(hero.Lucky)*1.5 - enemy.Defense)); //0 - 75
            hero.MagicPoints -= 2;
        }
        //Se modificó el código para evitar curación.
    }
    
    // A4 (4 PUNTOS)
    public void UnitedAttack(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        //checa si la velocidad del enemigo es mayor al promedio de velocidad de los heroes
        if(enemy.Speed >= (int)(heroA.Speed + heroB.Speed + heroC.Speed)/3)
        {
            System.Random random = new System.Random();
            
            //Elige al azar a un heroe para atacar.
            switch(random.Next(3))
            {
                case 0:
                heroA.LifePoints -=  Math.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroA.Defense);
                break;

                case 1:
                heroB.LifePoints -= Math.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroB.Defense);
                break;

                case 2:
                heroC.LifePoints -= Math.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroC.Defense);
                break;
            }    
            //se modificó el código para evitar curación.
        }
        //Si el promedio es mayor que la velocidad del enemigo 
        else
        {
            //los 3 heroes atacan al mismo tiempo.
            enemy.LifePoints -= Math.Abs(((heroA.Attack)*heroA.criticalHit(heroA.Lucky) +
            (heroB.Attack)*heroB.criticalHit(heroB.Lucky) + 
            (heroC.Attack)*heroC.criticalHit(heroC.Lucky) - enemy.Defense));
        }
    }

    // B1 (1 PUNTO)
    public void DefendFromEnemy(Enemy enemy , Hero hero)
    {
        //El enemgio se defiende y hace daño directo al heroe
        hero.LifePoints = hero.LifePoints - Math.Abs(((enemy.Attack)*enemy.criticalHit(enemy.Lucky))/2); // 50 - 100 
        //se modifico el código para evitar curacion.
    }

    // B2 (1 PUNTO)
    public bool EscapeFromEnemies(Enemy enemyA, Enemy enemyB, Hero heroA,Hero heroB, Hero heroC)
    {
        bool succesfulyEscaped = false;
        //Si la suma de las velocidades de los enemigos es mayor a la suma de la velocidad de los heroes, los enemigos escapan.  
        if(enemyA.Speed + enemyB.Speed > heroA.Speed + heroB.Speed + heroC.Speed)
        {
            succesfulyEscaped = true;
        }
        return succesfulyEscaped;
        //se modificó el código para retornar el valor.
    }
    // B3 (1 PUNTO)
    public void GetExperience(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        //Divide el nivel del enemigo entre 3 y se lo da a los heroes
        heroA.Experience = (int)enemy.Level/3;
        heroB.Experience = (int)enemy.Level/3;
        heroC.Experience = (int)enemy.Level/3;
    }

}