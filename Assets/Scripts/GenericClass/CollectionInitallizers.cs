using UnityEngine;
using System.Collections;
using System.Collections.Generic ;
namespace GenericClass
{
    public class Person
    {
        public string Name { get; set; }
    }
    public class CollectionInitallizers : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<Person> people = new List<Person>
            {
                new Person{Name = "ȫ�浿"},
                new Person{Name = "��λ�"},
                new Person{Name = "����"}

            };

            foreach (var p in people)
            {
                Debug.Log(p.Name);
            }
        }

    }
}