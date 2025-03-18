using System.Linq;
using UnityEngine;

public class LinqAverage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 5 };

        double average = numbers.Average();
        Debug.Log($"numbers ¹è·Ä Æò{average:#.##}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
