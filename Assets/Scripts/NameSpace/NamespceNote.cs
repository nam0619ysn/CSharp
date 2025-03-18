using UnityEngine;
using Korea.Seoul;
public class NamespceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();

        Car seoul = new Car();
        seoul.Run();

    }

   
}
