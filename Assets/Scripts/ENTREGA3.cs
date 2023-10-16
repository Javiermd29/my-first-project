using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENTREGA3 : MonoBehaviour
{

    //Ejercicio1
    [SerializeField] private float num1 = 2;
    [SerializeField] private float num2 = 9;

    //Ejercicio2 X
    [SerializeField] private string letter = "j";

    //Ejercicio3 X
    [SerializeField] private int num3 = 4;
    [SerializeField] private int num4 = 2;

    //Ejercicio4
    [SerializeField] private string value;

    //Ejercicio5 X
    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    //Ejercicio6
    [SerializeField] private int birthYear = 1997;

    //Ejercicio7
    [SerializeField] private int dayHoroscope;
    [SerializeField] private int monthHoroscope;

    //Ejercicio8 X
    [SerializeField] private int dayOfWeek;

    //Ejercicio9
    [SerializeField] private int ageDiscount;
    [SerializeField] private string rankDiscount;

    //Ejercicio10
    [SerializeField] private int side1;
    [SerializeField] private int side2;
    [SerializeField] private int side3;

    void Start()
    {
        //Ejercicio2
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
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
            Debug.Log(day + "/" + month + "/" + year + " es una fecha v�lida");
        }
        else
        {
            Debug.Log(day + "/" + month + "/" + year + " no es una fecha v�lida");
        }

        //Ejercicio 6

        //Ejercicio7
        switch (monthHoroscope)
        {
            case 1: if (dayHoroscope < 20) {
                    Debug.Log("Eres Capricornio");
                }
                else
                {
                    Debug.Log("Eres Acuario");
                }
                break;
            case 2:
                if (dayHoroscope < 19)
                {
                    Debug.Log("Eres Acuario");
                }
                else
                {
                    Debug.Log("Eres Piscis");
                }
                break;
            case 3:
                if (dayHoroscope < 21)
                {
                    Debug.Log("Eres Piscis");
                }
                else
                {
                    Debug.Log("Eres Aries");
                }
                break;
            case 4:
                if (dayHoroscope < 20)
                {
                    Debug.Log("Eres Aries");
                }
                else
                {
                    Debug.Log("Eres Tauro");
                }
                break;
            case 5:
                if (dayHoroscope < 21)
                {
                    Debug.Log("Eres Tauro");
                }
                else
                {
                    Debug.Log("Eres G�minis");
                }
                break;
            case 6:
                if (dayHoroscope < 21)
                {
                    Debug.Log("Eres G�minis");
                }
                else
                {
                    Debug.Log("Eres C�ncer");
                }
                break;
            case 7:
                if (dayHoroscope < 23)
                {
                    Debug.Log("Eres C�ncer");
                }
                else
                {
                    Debug.Log("Eres Leo");
                }
                break;
            case 8:
                if (dayHoroscope < 23)
                {
                    Debug.Log("Eres Leo");
                }
                else
                {
                    Debug.Log("Eres Virgo");
                }
                break;
            case 9:
                if (dayHoroscope < 23)
                {
                    Debug.Log("Eres Virgo");
                }
                else
                {
                    Debug.Log("Eres Libra");
                }
                break;
            case 10:
                if (dayHoroscope < 23)
                {
                    Debug.Log("Eres Libra");
                }
                else
                {
                    Debug.Log("Eres Escorpio");
                }
                break;
            case 11:
                if (dayHoroscope < 22)
                {
                    Debug.Log("Eres Escorpio");
                }
                else
                {
                    Debug.Log("Eres Sagitario");
                }
                break;
            case 12:
                if (dayHoroscope < 22)
                {
                    Debug.Log("Eres Sagitario");
                }
                else
                {
                    Debug.Log("Eres Capricornio");
                }
                break;
        }


        //Ejercicio8
        if (dayOfWeek < 6)
        {
            Debug.Log("Est�s entre semana");
        }
        else
        {
            Debug.Log("Est�s en fin de semana");
        }

        //Ejercicio9
        if (ageDiscount >= 65 && rankDiscount == "gold")
        {
            Debug.Log("Tienes un 75% de descuento");
        } else if (ageDiscount >= 65 && rankDiscount == "silver")
        {
            Debug.Log("Tienes un 50% de descuento");
        } else if (ageDiscount >= 65 && rankDiscount == "bronze")
        {
            Debug.Log("Tienes un 25% de descuento");
        } else if ((ageDiscount <= 65 && ageDiscount >= 18) && rankDiscount == "gold")
        {
            Debug.Log("Tienes un 50% de descuento");
        } else if ((ageDiscount <= 65 && ageDiscount >= 18) && rankDiscount == "silver")
        {
            Debug.Log("Tienes un 25% de descuento");
        } else if ((ageDiscount <= 65 && ageDiscount >= 18) && rankDiscount == "bronze")
        {
            Debug.Log("Tienes un 15% de descuento");
        } else if (ageDiscount < 18)
        {
            Debug.Log("No puedes ser miembro de la tienda y no recibir�s ning�n descuento");
        }

        //Ejercicio10
        if ((side1 + side2 + side3) == 180)
        {
            Debug.Log("Es un triangulo");
        }
        else
        {
            Debug.Log("No es un triangulo");
        }
    }
}
