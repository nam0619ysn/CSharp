using UnityEngine;
using UnityEngine.UIElements;
namespace GenericClass
{
    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }

            MyList<string> names = new MyList<string>(3);
            names[0] = "홍길동";
            names[1] = "백두신";
            names[2] = "장길산";
            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }

       
    }
}