using System;
using UnityEngine;

public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Nullable<bool> bln = null;
        Debug.Log(bln.HasValue);
        bln = false;
        Debug.Log(bln.HasValue);

        int? ni = null;
        ni = 10;
        Debug.Log(ni);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
