using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // public string name;

    public void FuncionUno (string name)
    {
        Debug.Log(FuncionDos(name));
    }

    public string FuncionDos (string name)
    {
        return name + " Llamaron a la FuncionUno, soy el script A " + this.name;
    }
}
