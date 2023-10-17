using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ENTREGA3 : MonoBehaviour
{

    //Ejercicio1
    [SerializeField] private float num1 = 2;
    [SerializeField] private float num2 = 9;

    //Ejercicio2
    [SerializeField] private string letter = "j";

    //Ejercicio3
    [SerializeField] private int num3 = 4;
    [SerializeField] private int num4 = 2;

    //Ejercicio4
    [SerializeField] private float grade;

    //Ejercicio5
    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    //Ejercicio6
    [SerializeField] private int birthYear;

    //Ejercicio7
    [SerializeField] private int dayHoroscope;
    [SerializeField] private int monthHoroscope;

    //Ejercicio8
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
        //Ejercicio1
        if (num1 > num2)
        {
            Debug.Log(num1 + " es más grande que " + num2);
        }
        else
        {
            Debug.Log(num2 + " es más grande que " + num1);
        }

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

        //Ejercicio4
        if (grade < 0 || grade > 10)
        {
            Debug.Log("La nota no es válida");
        }
        if (grade >= 9)
        {
            Debug.Log("A");
        }
        else if (grade >= 7)
        {

            Debug.Log("B");

        }
        else if (grade >= 5)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("D");
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
        int resultChinese = birthYear % 12;

        switch (resultChinese)
        {
            case 0: Debug.Log("Mono");
                break;
            case 1: Debug.Log("Gallo");
                break;
            case 2: Debug.Log("Perro");
                break;
            case 3: Debug.Log("Cerdo");
                break;
            case 4: Debug.Log("Rata");
                break;
            case 5: Debug.Log("Buey");
                break;
            case 6: Debug.Log("Tigre");
                break;
            case 7: Debug.Log("Conejo");
                break;
            case 8: Debug.Log("Dragon");
                break;
            case 9: Debug.Log("Serpiente");
                break;
            case 10: Debug.Log("Caballo");
                break;
            case 11: Debug.Log("Cabra");
                break;
        }

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
                    Debug.Log("Eres Géminis");
                }
                break;
            case 6:
                if (dayHoroscope < 21)
                {
                    Debug.Log("Eres Géminis");
                }
                else
                {
                    Debug.Log("Eres Cáncer");
                }
                break;
            case 7:
                if (dayHoroscope < 23)
                {
                    Debug.Log("Eres Cáncer");
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
            Debug.Log("Estás entre semana");
        }
        else
        {
            Debug.Log("Estás en fin de semana");
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
            Debug.Log("No puedes ser miembro de la tienda y no recibirás ningún descuento");
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
