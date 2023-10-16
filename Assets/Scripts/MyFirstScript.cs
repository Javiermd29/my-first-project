using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Esto es una prueba de comentario
    /*
    private int age =  26;
    private float price = 6.2f;
    private bool isGameOver = false;
    private string name = "Javier Martinez Dominguez";

    */

    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int coins;

    [SerializeField] private int hora;

    private void Start()
    {
        /* 
         Debug.Log("Hello world!");
         Debug.Log(name);
         Debug.Log(age);
         Debug.Log(price);
         Debug.Log(isGameOver);

         //Forma 1
         Debug.Log($"El nombre del usuario es: {name}");

         //Forma 2
         Debug.Log(string.Format("El precio del objeto es: {0} m/s", price));

         //Forma 3
         Debug.Log("El usuario tiene " + age + " años.");
        */
        /*
            Debug.Log(2 + 5);
            Debug.Log("Monedas: " + coins);
            // coins = coins + 10;
            coins += 10;
            Debug.Log("Monedas: " + coins);
        */

        Debug.Log(16 % 12);


    }
    
}
