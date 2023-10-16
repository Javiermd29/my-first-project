using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AND : MonoBehaviour
{

    private bool isMonday = true;
    private bool computersWork = true;

    void Start()
    {
        if (isMonday && computersWork)
        {
            Debug.Log("Tenemos clase de RMPI");
        }
        else
        {
            Debug.Log("No hay clase");
        }
    }
}
