using UnityEngine;
namespace Constructor
{
    public class Car
    {
        private string color;

        public Car()
        {
            color = "�Ͼ�";
            Debug.Log($"{color}�� �ڵ���");
        }

        public Car(string _car)
        {
            this.color = _car;
            Debug.Log($"{color}�� �ڵ���");
        }

        public void Run()
        {
            Debug.Log($"{color}�� �ڵ����� �޸���");
        }
        ~Car()
        {
            Debug.Log($"{color}�� �ڵ����� �����Ѵ�");
        }
    }
}