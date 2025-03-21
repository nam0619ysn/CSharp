using UnityEngine;
namespace Property
{
    public class ObjectInitalizer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Student s1 = new Student();
            s1.Name = "ȫ�浵";
            s1.Age = 22;
            Debug.Log($"�̸�:{s1.Name} ����:{s1.Age} ��ȣ:{s1.Number}");


            Student s2 = new Student() { Name = "��λ�", Age = 20, Number = 2 };       
            Debug.Log($"�̸�:{s2.Name} ����:{s2.Age} ��ȣ:{s2.Number}");

            Student s3 = new Student() { Name = "����", Age = 18, Number = 3 };
            s3.SetAddress("�����");
            Debug.Log($"�̸�:{s3.Name} ����:{s3.Age} ��ȣ:{s3.Number} �ּ�:{s3.GetAddress()}");

        }


    }
}