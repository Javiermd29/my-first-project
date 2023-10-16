using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class if_anidado : MonoBehaviour
{

    private int grade = 7;

    void Start()
    {

        if (grade >= 9)
        {
            if (grade == 9)
            {
                Debug.Log("Excelente");
            }
            if (grade == 9)
            {
                Debug.Log("Matricula de honor");
            }
        }
        else if (grade >= 7)
        {
            if (grade == 8)
            {
                Debug.Log("Notable alto");
            }
            if (grade == 7)
            {
                Debug.Log("Notable bajo");
            }
        }
        else if(grade >= 5)
        {
            if (grade == 6)
            {
                Debug.Log("Aprobado alto");
            }
            if (grade == 5)
            {
                Debug.Log("Aprobado bajo");
            }
        }
        else
        {
            Debug.Log("Supenso");
        }
    }
}