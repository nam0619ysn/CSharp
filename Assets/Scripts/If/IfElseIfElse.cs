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
            Debug.Log("number1�� Ů�ϴ�");
        }
        else if(number2>number1)
        {
            Debug.Log("number2�� ũ��.");

        }
       else
        {
            Debug.Log("���̰���");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
