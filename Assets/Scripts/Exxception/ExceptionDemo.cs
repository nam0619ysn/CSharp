using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //try
        //{
        //    int[] arr = new int[2];
        //    arr[100] = 10;
        //}
        //catch(System.Exception ex)
        //{
        //    Debug.Log(ex.Message);
        //}

        string inputNumber="3.14";
        int number = 0;
        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"입력값{number}");
        }
        catch(System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}는 정수여야 한다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
