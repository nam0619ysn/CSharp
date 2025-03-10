using UnityEngine;

public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float[] arr = {10.5f,201.1f,30.3f };
        float sum = 0f;

        //for(int i=0; i<3; i++)
        //{
        //    sum = sum + arr[i];
        //}

        foreach(float f in arr)
        {
            sum = sum + f;
        }

        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
