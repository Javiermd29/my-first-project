using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosExtra : MonoBehaviour
{
    //Ejercicios 1, 2 y 3
    private int numP = 2;
    private int numN = -4;
    private int num = -2;

    void Start()
    {
        if (numP > 0)
        {
            Debug.Log("Es positivo");
        }
        
        if (numN < 0)
        {
            Debug.Log("Es negativo");
        }

        if (num < 0)
        {
            Debug.Log("Es negativo");
        }else if (num > 0)
        {
            Debug.Log("Es positivo");
        } else if (num == 0)
        {
            Debug.Log("Es 0");
        }
    }
}
