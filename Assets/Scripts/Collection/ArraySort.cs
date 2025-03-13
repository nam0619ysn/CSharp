using UnityEngine;

public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5 };

        for(int i=0; i<arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("========");
        System.Array.Sort(arr);

        foreach(var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========");

        System.Array.Reverse(arr);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
