using UnityEngine;
namespace InterfaceTest
{
    public class CarWord : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car campingCar = new Car("캨핑카");
            campingCar.Run();

            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();

            Car cars = new Car(2);
            cars[0] = "1번";
            cars[1] = "2번";
            
        }


    }
}
