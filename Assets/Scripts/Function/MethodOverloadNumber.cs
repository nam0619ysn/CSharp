using UnityEngine;

public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);


    }

    // Update is called once per frame
    void PrintNumber(int number)
    {
        Debug.Log($"Int32:{number}");
    }
    void PrintNumber(long number)
    {
        Debug.Log($"Int64:{number}");
    }

    void PrintNumber(float number)
    {
        Debug.Log($"½Ç¼öÇü:{number}");
    }
}
