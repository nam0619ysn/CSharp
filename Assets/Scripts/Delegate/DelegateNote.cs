using PrivatePublic;
using UnityEngine;
namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        delegate void GoHome();
        GoHome go;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoLeft();

            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoForward);
            go();

            //Say say = new Say(Hello);
            //say += new Say(HI);
            //say.Invoke();

           


        }
        void Hello() => Debug.Log("Hello");


            //}
        

    }
}