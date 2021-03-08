using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dados : MonoBehaviour
{
  
    public void throwDice()
    {
        int diceOne, diceTwo, diceThree;

        diceOne = Random.Range(1,7);
        diceTwo = Random.Range(1,7);
        diceThree = Random.Range(1,7);

        if (diceOne == diceTwo && diceOne == diceThree)
        {
            Debug.Log("Ganaste");
        }
        else Debug.Log("Perdiste");
    }
}
