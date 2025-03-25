using System;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

        class A
        {
            private string[] days = { "일","월","화","수","목","금","토" };

             public void PrintDays()
             {
                foreach (string day in days)
                {
                  Debug.Log(day);
                }
             }
            public static int Add(int x, int y)
            {
                return x + y;
            }
         }

   class B
    {
        static void Main(string[] args)
        {
            
            A a = new A();
            a.PrintDays();

            
            int result = A.Add(5, 6);
           Debug.Log(result);
        }


    }
}
