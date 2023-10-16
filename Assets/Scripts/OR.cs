using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OR : MonoBehaviour
{

    private bool isMonday = true;
    private bool isTuesday = false;
    private bool computersWork = true;

    void Start()
    {

        if ((isMonday || isTuesday) && computersWork)
        {
            Debug.Log("Hay clase de RPMI");           
        }
        else
        {
            Debug.Log("No hay clase de RPMI");
        }

    }
}
