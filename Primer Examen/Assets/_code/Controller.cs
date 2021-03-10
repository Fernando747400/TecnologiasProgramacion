using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class Controller : MonoBehaviour
{
    public InputField squareVerticesInput;
    public InputField squareSizeInput;
    public InputField rectangleVerticesInput;
    public InputField rectangleLargeSideInput;
    public InputField rectangleSmallSideInput;
    public InputField triangleVerticesInput;
    public InputField triangleSizeInput;
    public InputField circleVerticesInput;
    public InputField circleRadiusInput;
    int squareVertices;
    double squareSize;
    int rectangleVertices;
    double rectangleSmallSide;
    double rectangleBigSide;
    int triangleVertices;
    double triangleSize;
    int circleVertices;
    double circleRadius;
    private List<Square> squaresList = new List<Square>();
    private List<Rectangle> rectanglesList = new List<Rectangle>();
    private List<Triangle> trianglesList = new List<Triangle>();
    private List<Coin> coinsList = new List<Coin>();
    private List<Bullet> bulletsList = new List<Bullet>();
    private List<Enemy> enemiesList = new List<Enemy>();
    private List<Companion> companionsList = new List<Companion>();

    void Start()
    {
        initializeInputField();
    }

    //Methods

    public void squareCreation()
    {
        int.TryParse(squareVerticesInput.text, out squareVertices);
        double.TryParse(squareSizeInput.text, out squareSize);
        if (squareVertices == 4)
        {
            Square mySquare = new Square(squareVertices, squareSize);
            squaresList.Add(mySquare);
            Debug.Log("Cuadrado creado");
        }
        else Debug.Log("Un cuadrado debe tener cuatro v�rtices");
    }

    public void squaresListPrint()
    {
        if (squaresList.Count != 0)
        {
            int i = 1;
            foreach (var square in squaresList)
            {
                Debug.Log("Cuadrado n�mero " + i + ": ");
                Debug.Log("V�rtices: " + square.Vertices);
                Debug.Log("Tama�o: " + square.Size);
                i++;               
            }
        }
    }

    public void rectangleCreation()
    {
        int.TryParse(rectangleVerticesInput.text, out rectangleVertices);
        double.TryParse(rectangleSmallSideInput.text, out rectangleSmallSide);
        double.TryParse(rectangleLargeSideInput.text, out rectangleBigSide);
        if (rectangleVertices != 4)
        {
            Debug.Log("Un rect�ngulo debe tener cuatro v�rtices");
        } else if (rectangleSmallSide > rectangleBigSide)
        {
            Debug.Log("El lado peque�o es m�s grande que el lado grande");
        } else
        {
            Rectangle myRectangle = new Rectangle(rectangleVertices, rectangleSmallSide, rectangleBigSide);
            rectanglesList.Add(myRectangle);
            Debug.Log("Rect�ngulo creado");
        }
    }

    public void rectanglesListPrint()
    {
        if (rectanglesList.Count != 0)
        {
            int i = 1;
            foreach (var rectangle in rectanglesList)
            {
                Debug.Log("Rect�ngulo n�mero " + i + ": ");
                Debug.Log("V�rtices: " + rectangle.Vertices);
                Debug.Log("Lado peque�o: " + rectangle.SmallSide);
                Debug.Log("Lado grande: " + rectangle.BigSide);
                i++;
            }
        }
    }

    public void triangleCreation()
    {
        int.TryParse(triangleVerticesInput.text, out triangleVertices);
        double.TryParse(triangleSizeInput.text, out triangleSize);
        if (triangleVertices !=3)
        {
            Debug.Log("Un tri�ngulo debe tener tres v�rtices");
        } else
        {
            Triangle myTriangle = new Triangle(triangleVertices, triangleSize);
            trianglesList.Add(myTriangle);
            Debug.Log("Tri�ngulo creado");
        }
    }

    public void trianglesListPrint()
    {
        if (trianglesList.Count != 0)
        {
            int i = 1;
            foreach (var triangle in trianglesList)
            {
                Debug.Log("Tri�ngulo n�mero " + i + ": ");
                Debug.Log("V�rtices: " + triangle.Vertices);
                Debug.Log("Tama�o: " + triangle.Size);
                i++;
            }
        }
    }

    public void circleCreation()
    {
        int.TryParse(circleVerticesInput.text, out circleVertices);
        double.TryParse(circleRadiusInput.text, out circleRadius);

        int selection = Random.Range(1,5);

        switch (selection)
        {
            case 1:
                Coin myCoin = new Coin(circleVertices,circleRadius,"Normal", true, Random.Range(1,10));
                coinsList.Add(myCoin);
            break;

            case 2:
                Bullet myBullet = new Bullet(circleVertices, circleRadius, Random.Range(1,100), Random.Range(1,20), Random.Range(1,100));
                bulletsList.Add(myBullet);
                break;

            case 3:
                Enemy myEnemy = new Enemy(circleVertices,circleRadius,Random.Range(1,100),Random.Range(1,100),Random.Range(1,10));
                enemiesList.Add(myEnemy);
                break;
            case 4:
                Companion myCompanion = new Companion(circleVertices,circleRadius,Random.Range(1,100),Random.Range(1,100), true);
                companionsList.Add(myCompanion);
                break;
        }
        Debug.Log("C�rculo creado");
    }

    public void coinsListPrint()
    {
        if (coinsList.Count != 0)
        {
            int i = 1;
            foreach (var coin in coinsList){
                Debug.Log("Moneda: " + i);
                Debug.Log("V�rtices: " + coin.Vertices);
                Debug.Log("Radio: " + coin.Radius);
                Debug.Log("Valor: " + coin.Worth);
                Debug.Log("Activa: " + coin.Active);
                Debug.Log("Multiplicador: " + coin.Multiplier);
                i++;
            }
        }
    }

    public void bulletsListPrint()
    {
        if (bulletsList.Count != 0)
        {
            int i = 1;
            foreach (var bullet in bulletsList)
            {
                Debug.Log("Bala: " + i);
                Debug.Log("V�rtices: " + bullet.Vertices);
                Debug.Log("Radio: " + bullet.Radius);
                Debug.Log("Da�o: " + bullet.Damage);
                Debug.Log("Velocidad: " + bullet.Speed);
                Debug.Log("Precisi�n: " + bullet.Precision);
                i++;
            }
        }
    }

    public void enemiesListPrint()
    {
        if (enemiesList.Count != 0)
        {
            int i = 1;
            foreach (var enemy in enemiesList)
            {
                Debug.Log("Enemigo: " + i);
                Debug.Log("V�rtices: " + enemy.Vertices);
                Debug.Log("Radio: " + enemy.Radius);
                Debug.Log("Vida: " + enemy.Health);
                Debug.Log("Da�o: " + enemy.Damage);
                Debug.Log("Fuerza: " + enemy.Strength);
                i++;
            }
        }
    }

    public void companionsListPrint()
    {
        if (companionsList.Count != 0)
        {
            int i = 1;
            foreach (var companion in companionsList)
            {
                Debug.Log("Compa�ero " + i);
                Debug.Log("V�rtices: " + companion.Vertices);
                Debug.Log("Radio: " + companion.Radius);
                Debug.Log("Vida: " + companion.Health);
                Debug.Log("Da�o: " + companion.Damage);
                Debug.Log("Vivo: " + companion.IsAlive);
                i++;
            }
        }
    }

    public void printLists()
    {
        squaresListPrint();
        rectanglesListPrint();
        trianglesListPrint();
        coinsListPrint();
        bulletsListPrint();
        enemiesListPrint();
        companionsListPrint();
    }
    public void initializeInputField()
    {
        if (squareVerticesInput == null) squareVerticesInput = GetComponent<InputField>();
        if (squareSizeInput == null) squareSizeInput = GetComponent<InputField>();
        if (rectangleVerticesInput == null) rectangleVerticesInput = GetComponent<InputField>();
        if (rectangleLargeSideInput == null) rectangleLargeSideInput = GetComponent<InputField>();
        if (rectangleSmallSideInput == null) rectangleSmallSideInput = GetComponent<InputField>();
        if (triangleVerticesInput == null) triangleVerticesInput = GetComponent<InputField>();
        if (triangleSizeInput == null) triangleSizeInput = GetComponent<InputField>();
        if (circleVerticesInput == null) circleVerticesInput = GetComponent<InputField>();
        if (circleRadiusInput == null) circleRadiusInput = GetComponent<InputField>();
    }
}
