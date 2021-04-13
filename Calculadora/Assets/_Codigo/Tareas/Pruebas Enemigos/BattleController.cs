using UnityEngine;

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

}


}