using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] intArray = new int[3] { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 값으니{intArray[i]}");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
