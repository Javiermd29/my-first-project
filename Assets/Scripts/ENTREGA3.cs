using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENTREGA3 : MonoBehaviour
{

    //Ejercicio1
    [SerializeField] private float num1 = 2;
    [SerializeField] private float num2 = 9;

    //Ejercicio2
    [SerializeField] private string letra = "j";

    //Ejercicio3
    [SerializeField] private int num3 = 4;
    [SerializeField] private int num4 = 2;

    //Ejercicio4
    [SerializeField] private string value;

    //Ejercicio5
    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    //Ejercicio6
    [SerializeField] private int birthYear = 1997;
    private int chineseYear = 1997;

    //Ejercicio7
    [SerializeField] private int dayHoroscope;
    [SerializeField] private int yearHoroscope;

    //Ejercicio8
    [SerializeField] private int dayOfWeek;
    void Start()
    {
        //Ejercicio2
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log("Es una vocal");
        }
        else
        {
            Debug.Log("Es una consonante");
        }

        //Ejercicio3
        if (num3 % num4 == 0)
        {
            Debug.Log("Es divisible");
        }
        else
        {
            Debug.Log("No es divisible");
        }

        //Ejercicio5
        if ((day >= 1 && day <= 31) && (month >= 1 && month <= 12) && (year >= 1))
        {
            Debug.Log(day + "/" + month + "/" + year + " es una fecha válida");
        }
        else
        {
            Debug.Log(day + "/" + month + "/" + year + " no es una fecha válida");
        }

        //Ejercicio 6

        Debug.Log(chineseYear % 12);

        /*if (chineseYear == 2)
        {
            Debug.Log("Es el año del buey");
        }
        */

        //Ejercicio7
         
        //Ejercicio8
        if (dayOfWeek < 6)
        {
            Debug.Log("Estás entre semana");
        }
        else
        {
            Debug.Log("Estás en fin de semana");
        }
    }
}
