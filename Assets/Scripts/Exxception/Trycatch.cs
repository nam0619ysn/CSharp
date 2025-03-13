using UnityEditor;
using UnityEngine;

public class Trycatch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
             int[] arr = new int[2];
                arr[100] = 10;
        }
        catch
        {
            Debug.Log("¿¡·¯");
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
