using UnityEngine;
namespace Override
{
    public class MethodVirtual : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Animal animal = new Animal();
            //animal.Eat();

            //Dog dog = new Dog();
            //dog.Eat();

            //Cat cat = new Cat();
            //cat.Eat();

            //Animal dog2 = new Dog();
            //dog2.Eat();

            Animal aDog = new Dog();
            aDog.Eat();

            Animal bcat = new Cat();
            bcat.Eat();


        }

       
    }
}