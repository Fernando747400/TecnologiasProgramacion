using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Calculation 
{
     static int numeroUno = 5;
     static int numeroDos = 2;


    public static int suma(int numeroUno, int numeroDos)
    {
        int resultado;
        resultado = numeroUno + numeroDos;
        return resultado;
    }

    public static int resta(int numeroUno, int numeroDos)
    {
        int resultado;
        resultado = numeroUno - numeroDos;
        return resultado;
    }
}
