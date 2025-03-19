using System.Globalization;
using UnityEngine;
namespace Constructor
{
    public class Person
    {
        private string name;

        public Person()
        {
            name = "ȫ�浿";
        }

        public Person(string _name)
        {
            _name=name ;
        }

        public string GetName()
        {
            return name;
        }

    }
}
