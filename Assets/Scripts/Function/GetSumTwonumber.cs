using UnityEngine;

public class GetSumTwonumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = GetSum(3, 4);
        Debug.Log(result);
    }

    // Update is called once per frame
    int GetSum(int x,int y)
    {
        //int sum = x + y;
        //return sum;
        return (x + y); 
    }
}
