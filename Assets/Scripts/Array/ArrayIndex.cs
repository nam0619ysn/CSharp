using UnityEngine;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1,2,3 };
        int index = 0;

        Debug.Log(numbers[index++]);
        Debug.Log(numbers[index++]);
        Debug.Log(numbers[index++]);

        Debug.Log(numbers[--index]);
        Debug.Log(numbers[--index]);
        Debug.Log(numbers[--index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
