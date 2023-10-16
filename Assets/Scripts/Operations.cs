using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int num;

    void Start()
    {
        /*
        Debug.Log(num1 + " + " + num2 + " = " + (num1 + num2));
        Debug.Log(num1 + " - " + num2 + " = " + (num1 - num2));
        Debug.Log(num1 + " x " + num2 + " = " + (num1 * num2));
        Debug.Log(num1 + " / " + num2 + " = " + (num1 / num2));
        */

        Debug.Log(num % 12);

    }

}
