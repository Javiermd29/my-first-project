using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    /*
    [SerializeField] private float num = 2;
    private bool monday = false;
    private bool tuesday = false;
    private bool wednesday = false;
    private bool thursday = false;
    private bool friday = false;
    private bool saturday = false;
    */

    private int lives = 5;

    // Start is called before the first frame update
    void Start()
    {

        /* if (num > 0)
        {
            Debug.Log("Es positivo");
        }

        if (num < 0)
        {
            Debug.Log("Es negativo");
        }
        

        if (monday)
        {
            Debug.Log("Es lunes");
        }
        else if (tuesday)
        {
            Debug.Log("Es martes");
        }
        else if (wednesday)
        {
            Debug.Log("Es miércoles");
        }
        else if (thursday)
        {
            Debug.Log("Es jueves");
        }
        else if (friday)
        {
            Debug.Log("Es viernes");
        }
        else if (saturday)
        {
            Debug.Log("Es sábado");
        }
        else
        {
            Debug.Log("Es domingo");
        }
        */

        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }
        else if(lives <= 1)
        {
            Debug.Log("Al loro que solo te queda una vida");
        }
        else if(lives <= 5)
        {
            Debug.Log("Puedes ir tranquilo, pero cuidado que tienes como mucho 5 vidas");
        }
    }
}
