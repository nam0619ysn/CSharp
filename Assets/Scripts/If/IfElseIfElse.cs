using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 = 10;
        int number2 = 10;

        if(number1> number2)
        {
            Debug.Log("number1이 큽니다");
        }
        else if(number2>number1)
        {
            Debug.Log("number2가 크다.");

        }
       else
        {
            Debug.Log("둘이같다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
