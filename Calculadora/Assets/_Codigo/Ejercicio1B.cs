using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1B : MonoBehaviour
{
    [SerializeField]
   // private static string name;
    private Ejercicio1 scriptA;

    public void Start()
    {
        scriptA = FindObjectOfType<Ejercicio1>();
        scriptA.FuncionUno(name);
    }
}
