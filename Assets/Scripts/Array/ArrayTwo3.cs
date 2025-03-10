using UnityEngine;

public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[][] intArray = new int[2][];
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4,5};
        Debug.Log($"배열의 길이:{intArray.Length}");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("======");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
