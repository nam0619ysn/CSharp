using System.Collections.Generic;
using UnityEngine;

public class Listioflstring : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        List<string> colors = new List<string>();


        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        foreach(var s in colors)
        {
            Debug.Log(s);
        }

    }
}

