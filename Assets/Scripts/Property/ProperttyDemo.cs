using Korea.Seoul;
using PrivatePublic;
using UnityEngine;
namespace Property
{
    public class ProperttyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car car1 = new Car();
            car1.SetColor("Red");
            Debug.Log(car1.GetColor());

            Car car2 = new Car();
            car2.Color = "White";
            Debug.Log(car2.Color);

            Car car3 = new Car();
            //car3.Maker = "´ë¿ìÀÚµ¿Â÷";
            Debug.Log(car3.Maker);

            Car myCar = new Car();
            myCar.NAme = "ºÕºÕ";
            Debug.Log(myCar.NAme);
        }

      
    }
}
