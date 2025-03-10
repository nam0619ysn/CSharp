using UnityEngine;

public class ArrayTwo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray = { {1,2,3 },{4,5,6 } };

        Debug.Log($"배열의 길이:{intArray.Length}");

        for (int i = 0; i < intArray.GetLength(0); i++)
        {   Debug.Log("=====================");

            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
