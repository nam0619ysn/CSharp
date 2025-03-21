using UnityEngine;
namespace Property
{
    public class ObjectInitalizer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Student s1 = new Student();
            s1.Name = "홍길도";
            s1.Age = 22;
            Debug.Log($"이름:{s1.Name} 나이:{s1.Age} 번호:{s1.Number}");


            Student s2 = new Student() { Name = "백두산", Age = 20, Number = 2 };       
            Debug.Log($"이름:{s2.Name} 나이:{s2.Age} 번호:{s2.Number}");

            Student s3 = new Student() { Name = "장길산", Age = 18, Number = 3 };
            s3.SetAddress("서울시");
            Debug.Log($"이름:{s3.Name} 나이:{s3.Age} 번호:{s3.Number} 주소:{s3.GetAddress()}");

        }


    }
}