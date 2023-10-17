using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    private void Start()
    {
        SayHelloTo("Javi");
        SayHelloTo("Jose");
        SayHelloTo("Dani");

        Debug.Log("La suma de los 3 numeros es: " + SumThreeIntNumbers(1, 2, 3));

        Debug.Log(ShowUserInfo("Javi", 9));

    }

    private void HelloWorld()
    {
        // Cuerpo de la función
        Debug.Log("Hello World");
    }

    private void SayHelloTo(string name)
    {
        Debug.Log("Hello, " + name);
    }

    private int SumThreeIntNumbers(int num1, int num2, int num3)
    {
        int result = num1 + num2 + num3;
        return result;
    }

    private string ShowUserInfo(string username, int level)
    {
        string message = "El usuario " + username + " tiene nivel " + level;
        return message;
    }

    

}
