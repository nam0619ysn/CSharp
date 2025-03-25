using UnityEngine;
namespace Override
{
    public class Animal
    {
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.Log("�������� ���� �Դ´�.");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();

            Debug.Log("����װ� ���� �Դ´�.");
        }
    }
}

