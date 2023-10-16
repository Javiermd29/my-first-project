using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class EjercicioExtra5 : MonoBehaviour
{
    [SerializeField] private float precio;
    [SerializeField] private int descuento;
    private float total;

    void Start()
    {

        float total = precio - (precio / descuento);

        Debug.Log("El precio es " + precio + "€, el descuento es del " + descuento + 
            "% y el precio final es: " + total + "€");
    }
}
