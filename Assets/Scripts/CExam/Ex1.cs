using System;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
namespace CExam { 
public class Ex1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

            A a = new A();
            a.PrintDays();


            int result = A.Add(5, 6);
            Debug.Log(result);

        }
    public class A
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

    public class B
    {
       public void EC()
        {
            
            A a = new A();
            a.PrintDays();

            
            int result = A.Add(5, 6);
           Debug.Log(result);
        }


    }
}
    }