using UnityEngine;
namespace Interface
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            HdCar goodCar = new HdCar(new Good());
            //goodCar.Run();

            HdCar badCar = new HdCar(new Bad());
            //badCar.Run();
        }


    }
}