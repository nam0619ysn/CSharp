using UnityEngine;
namespace Constructor
{
    public class My
    {
        private string name;
        int age;

        public My(string _name,int _age)
        {
            this.name = _name;
            age = _age;
        }

        public void PrintMyInfo()
        {
            Debug.Log($"�̸�:{this.name},����:{this.age}");
        }
    }
}