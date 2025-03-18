using UnityEngine;
using System.Linq; 

public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3 };

        int count = numbers.Count();

        Debug.Log($"numbers ¹è¿­¤·¤Ò °¹¤µ¤Ì´Â{count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
