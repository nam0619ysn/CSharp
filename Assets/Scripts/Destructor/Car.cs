using UnityEngine;
namespace Constructor
{
    public class Car
    {
        private string color;

        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차");
        }

        public Car(string _car)
        {
            this.color = _car;
            Debug.Log($"{color}색 자동차");
        }

        public void Run()
        {
            Debug.Log($"{color}색 자동차가 달린다");
        }
        ~Car()
        {
            Debug.Log($"{color}색 자동차가 폐차한다");
        }
    }
}