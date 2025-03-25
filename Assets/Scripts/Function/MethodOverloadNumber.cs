using UnityEngine;

public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PrintNumber(1234);
        //PrintNumber(1234L);
        //PrintNumber(1234F);
        //PrintNumber(3.14);
        PrintNumber<int>(1234);
        PrintNumber<long>(1234L);
        PrintNumber<float>(1234f);
        PrintNumber<double>(3.14);

    }

    void PrintNumber<T>(T number)
    {
        Debug.Log($"{number}");
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
        Debug.Log($"실수형:{number}");
    } 
    void PrintNumber(double number)
    {
        Debug.Log($"더블형:{number}");
    }
}
