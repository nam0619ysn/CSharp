using UnityEngine;
namespace GenericClass
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Helllo<int> hi = new Helllo<int>();
            hi.Say(1234);

            Helllo<string> hs = new Helllo<string>("æ»≥Á«œººø‰");
            hs.Say(hs.GetMessage());
        }

       
    }
}
