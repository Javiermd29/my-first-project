using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioExtra4 : MonoBehaviour
{
    [SerializeField] private int nota;
    void Start()
    {
        if (nota <= 4)
        {
            Debug.Log("Has suspendido, estudia un poco más.");
        } else if (nota >= 5 & nota < 7)
        {
            Debug.Log("Has aprobado, pero podrías haber sacado mejor nota.");
        } else if (nota >= 7 & nota < 9)
        {
            Debug.Log("Has sacado un notable, muy bien!");
        } else if (nota >= 9)
        {
            Debug.Log("Has sacado un excelente, que bueno eres!!");
        }
    }
}
