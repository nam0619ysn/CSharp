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
            Debug.Log("°­¾ÆÁö°¡ ¹äÀ» ¸Ô´Â´Ù.");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();

            Debug.Log("°í¾çÀ×°¡ ¹äÀ» ¸Ô´Â´Ù.");
        }
    }
}

