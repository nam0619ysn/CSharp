using UnityEngine;
using Foo;
using Bar;
public class NamespaceDescruptuion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go();

        Bar.Car barCar = new Bar.Car();
        barCar.Go();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
