using UnityEngine;
namespace InterfaceTest
{
    public class CarWord : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car campingCar = new Car("�J��ī");
            campingCar.Run();

            Car sportCar = new Car();
            sportCar.Name = "������ī";
            sportCar.Run();

            Car cars = new Car(2);
            cars[0] = "1��";
            cars[1] = "2��";
            
        }


    }
}
