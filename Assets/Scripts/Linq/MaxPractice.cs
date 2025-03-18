using UnityEngine;
using System.Linq;


public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { -2,-5,-3,-7,-1 };
        int max = int.MinValue;
        
        for(int i=0;i<data.Length;i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
        }

        Debug.Log($"�ִ밪:{max}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
