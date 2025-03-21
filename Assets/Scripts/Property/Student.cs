using System.Xml.Serialization;
using UnityEngine;
namespace Property
{
    public class Student
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
        public int Number { get; set; } = 1;

        public void SetAddress(string value)
        {
            address = value;
        }
        public string GetAddress()
        {
            return address ;
        }
    }
}