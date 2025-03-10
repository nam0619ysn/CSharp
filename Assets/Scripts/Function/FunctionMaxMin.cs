using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int max= GetMax(3,5);

        Debug.Log($"가장 큰수{max}");

        int min = GetMin(-3, -5);

        Debug.Log($"가장 작은수{min}");
    }

    // Update is called once per frame
    int GetMax(int x,int y)
    {
        //int maxValue;
        //if (x > y)
        //{
        //    maxValue = x;
        //}
        //else
        //{
        //    maxValue = y;
        //}
        //return maxValue;

        //int maxValue = (x>y) ? x : y;
        //return maxValue;

        //return (x > y) ? x : y;

        if (x > y)
        {
           return x;
        }
        else
        {
            return y;
        }
    }

    

    int GetMin(int z, int t)
    {
        //int maxValue;
        //if (x > y)
        //{
        //    maxValue = x;
        //}
        //else
        //{
        //    maxValue = y;
        //}
        //return maxValue;

        //int maxValue = (x>y) ? x : y;
        //return maxValue;

        //return (x > y) ? x : y;

        if (z < t)
        {
            return z;
        }
        else
        {
            return t;
        }
    }

}
