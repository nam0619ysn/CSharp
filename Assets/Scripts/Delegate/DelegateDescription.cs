using UnityEngine;
namespace Delegate
{
    public class DelegateDescription : MonoBehaviour
    {
        delegate void SayDelegate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Hi();

            SayDelegate say = Hi;
            say();

            SayDelegate hello = new SayDelegate(Hi);
            hello();

            SayDelegate insa = new SayDelegate(Hi);

            insa.Invoke();
        }

        void Hi()
        {
            Debug.Log("æ»≥Á«œººø‰");    
        }

    }
}