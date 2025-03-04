using System.Data;
using UnityEngine;

public class ShortCutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        b += a;
        Debug.Log(b);

        b -= a;
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
