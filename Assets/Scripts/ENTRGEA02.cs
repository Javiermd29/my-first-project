using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENTRGEA02 : MonoBehaviour
{
    //Ejercicio 1 
    [SerializeField] private float num1; //8
    [SerializeField] private float num2; //4
    //Ejercicio 4
    private string mayor = "El primer número es mayor que el segundo";
    private string igual = "El primer número es igual que el segundo";
    //Ejercicio 5
    private string nombre = "Javier";
    //Ejercicio 7
    [SerializeField] private int num3; //9
    [SerializeField] private int num4; //2

    void Start()
    {
        //Ejercicio 2 Resultado 12
        Debug.Log(num1 + num2);

        //Ejercicio 3 Resultado el primero número es mayor que el segundo
        if (num1 > num2)
        {
            Debug.Log("El primer número es mayor que el segundo");
        }else if (num1 == num2)
        {
            Debug.Log("El primer número es igual que el segundo");
        }

        //Ejercicio 6 Resultado Bienvenido a los ejercicios de la Entrega02, Javier
        Debug.Log("Bienvenido a los ejercicio de la Entrega02, " + nombre);

        //Ejercicio 8 Resultado 1
        Debug.Log(num3 % num4);

        //Ejercicio 9
        //if (nombre.CompareTo("Mallorca"))
        //{
        //    Debug.Log(nombre + " es más largo que Mallorca");
       // }
        
    }
}
