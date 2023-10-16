using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    [SerializeField] private int numLegs;
    [SerializeField] private string nombre;

    private void Start()
    {
        Debug.Log("The " + nombre + " has " + numLegs + " legs");
    }

}
