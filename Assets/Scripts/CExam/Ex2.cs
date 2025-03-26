using System;
using UnityEngine;
namespace CExam
{
    public class Ex2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int[] numbers = { -2, -5, -3, -7, -1 };

            int min = numbers[0];

            //foreach (int num in numbers)
            //{
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}


            for (int num=0; num< numbers.Length;num++)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            Debug.Log("최소값은 " + min);
        }
    }
}

    

