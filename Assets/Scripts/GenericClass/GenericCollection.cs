using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GenericClass
{
    public class Student 
    {
        public string Name { get; set; }
        public int Number { get; set; }

    }
    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<Student> students = new List<Student>
            {
                new Student{Name = "ȫ�浿",Number=1},
                new Student{Name = "��λ�", Number=2},
                new Student{Name = "����",Number=3 }

            };

            Student student = new Student() { Name = "��ܺ�", Number = 4 };
            students.Add(student);

            foreach (var s in students)
            {
                Debug.Log($"{s.Number}-{s.Number}");
            }
        }
    }
}
