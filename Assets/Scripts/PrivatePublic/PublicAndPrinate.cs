using UnityEngine;
namespace PrivatePublic
{
    public class PublicAndPrinate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car myCar = new Car();

            myCar.name = "ȫ�浿";
            Debug.Log(myCar.name);

            myCar.Hi();
            //myCar.Bye();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}