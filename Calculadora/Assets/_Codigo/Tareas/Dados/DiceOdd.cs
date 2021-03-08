using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceOdd : Dice
{
    public DiceOdd()
    {

    }
    public DiceOdd(int anumberOfFaces)
    {
        numberOfFaces = anumberOfFaces;
    }
    public override int throwDice()
    {
        int answer;
        answer = Random.Range(1, numberOfFaces + 1);
        while (answer % 2 == 0)
        {
            answer = Random.Range(1, numberOfFaces + 1);
        }
        return answer;
    }

}
