using System.Linq;
using UnityEngine;

public class LinqSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3 };
        int sum = 0;

        sum = numbers.Sum();
        Debug.Log($"numbe ©Д╪р гу: {sum}");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
