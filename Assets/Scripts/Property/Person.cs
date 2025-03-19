using UnityEngine;
namespace Property
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name; 
        }
    }
}