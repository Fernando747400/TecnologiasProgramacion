using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class Calculadora : MonoBehaviour
{
    public ToggleGroup TG;
    public InputField inp1, inp2;
    public Text resultado;
    double num1, num2, res;

    // Start is called before the first frame update
    void Start()
    {
        if (inp1 == null) inp1 = GetComponent<InputField>();
        if (inp2 == null) inp2 = GetComponent<InputField>();
        if(resultado == null) resultado = GetComponent<Text>();
        if(TG == null) TG = GetComponent<ToggleGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        calculo();
    }

    void calculo()
    {
        double.TryParse(inp1.text, out num1);
        double.TryParse(inp2.text, out num2);
        switch (Seleccion())
        {
            case "+":
                res = num1 + num2;
                break;

            case "-":
                res = num1 - num2;
                break;
            case "*":
                res = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    res = num1 / num2;
                }
                else resultado.text = "No se puede dividir entre 0";             
                break;

        }
        resultado.text = res.ToString();
    }

    public string Seleccion()
    {
        string selec;
        Toggle selectedToggle = TG.ActiveToggles().FirstOrDefault();

       return selec = selectedToggle.name;
    }

}
