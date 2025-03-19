using UnityEngine;
namespace Method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Dog cat = new Dog();

            cat.Eat();
            cat.weight = 30;
        }

      
    }
}
