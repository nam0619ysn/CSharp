using System.Diagnostics.Tracing;
using UnityEngine;

public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = -3;
        int second = -8;
        int diff = 0;

        if(first >=second)
        {
            diff = first = second;
        }
        else
        {
            diff = second - first;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
