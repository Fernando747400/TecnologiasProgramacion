using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    Dice diceOne = new Dice(6);
    DiceEven diceEven = new DiceEven(6);
    DiceOdd diceOdd = new DiceOdd(6);
  
    public void throwDices()
    {
        Debug.Log("Resultado dado normal: " + diceOne.throwDice());
        Debug.Log("Resultado dado cargado pares: " + diceEven.throwDice());
        Debug.Log("Resultado dado cargado nones: " + diceOdd.throwDice());
    }
}
