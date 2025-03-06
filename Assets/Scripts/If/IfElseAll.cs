using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 21;

        if (number % 2 == 0)
        {
            Debug.Log($"{number}는 짝수");
        }
        else 
        {
            Debug.Log($"{number}는 홀수");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수");
        }
         if(number % 5 ==0)
        {
            Debug.Log($"{number}는 5의배수 ");
        }

         if (number % 7 == 0)
        {
            Debug.Log($"{number}는 7의배수 ");
        }
        //else
        //{
        //    Debug.Log($"{number}는 3,5,7의배수아니다. ");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
