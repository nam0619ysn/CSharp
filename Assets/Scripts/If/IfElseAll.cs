using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 21;

        if (number % 2 == 0)
        {
            Debug.Log($"{number}�� ¦��");
        }
        else 
        {
            Debug.Log($"{number}�� Ȧ��");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}�� 3�� ���");
        }
         if(number % 5 ==0)
        {
            Debug.Log($"{number}�� 5�ǹ�� ");
        }

         if (number % 7 == 0)
        {
            Debug.Log($"{number}�� 7�ǹ�� ");
        }
        //else
        //{
        //    Debug.Log($"{number}�� 3,5,7�ǹ���ƴϴ�. ");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
