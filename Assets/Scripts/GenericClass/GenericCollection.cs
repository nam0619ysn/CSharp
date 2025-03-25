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
                new Student{Name = "홍길동",Number=1},
                new Student{Name = "백두산", Number=2},
                new Student{Name = "장길산",Number=3 }

            };

            Student student = new Student() { Name = "김단비", Number = 4 };
            students.Add(student);

            foreach (var s in students)
            {
                Debug.Log($"{s.Number}-{s.Number}");
            }
        }
    }
}
