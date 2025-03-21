using UnityEngine;
namespace Inheritence10
{
    public class AbstractClassNode : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Squre squre = new Squre(10);
            Debug.Log(squre.GetArea());

            Circle circle = new Circle(4);
            Debug.Log(circle.GetArea());
        }

    }
}