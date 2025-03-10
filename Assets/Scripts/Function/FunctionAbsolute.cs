using UnityEngine;

public class FunctionAbsolute : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        //int abs = Abs(number);

        int abs = Mathf.Abs(number);
        Debug.Log($"{number}의 절대값{abs}");
    }

    // Update is called once per frame
    int Abs(int num)
    {
        //if (num < 0)
        //{
        //    return -num;
        //}
        //else
        //{
        //    return num;
        //}
        return (num < 0) ? -num : num;
    }
}
