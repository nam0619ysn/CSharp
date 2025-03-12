using System;
using UnityEngine;

public class RandomEmo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random rand = new System.Random();

        int[] numbers = new int[6];
        bool flag = false;
        int number=0;
        for (int i = 0; i < 6; i++)
        {

            number = rand.Next(1, 46);
            flag = false;
            if (i > 0)
            {
                for(int j=0; j < i; j++)
                {
                    if (numbers[j]==number)
                    {
                        flag = true;
                    }
                }
            }

            if (flag == false)
            {
                numbers[i] = number;
            }
            else
            {
                i--;
            }
        }

        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
