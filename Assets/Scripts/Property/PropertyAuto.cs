using UnityEngine;
namespace Property
{
    public class PropertyAuto : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Truck car1 = new Truck();
            car1.Name = "���׽ý�";
            Debug.Log(car1.Name);

            Truck car2 = new Truck();
            car2.Name = "�ƹ���";
            car2.Color = "Red";
            Debug.Log($"��:{car2.Name} ��:{car2.Color}");
        }

       
    }
}