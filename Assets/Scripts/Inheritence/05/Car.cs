using UnityEngine;
namespace Inheritence05
{
    public class Car
    {
        private string name;

        public Car(string _name)
        {
            this.name = _name;
        }

        public void Run() => Debug.Log($"{name}가 달린다");
    }
}