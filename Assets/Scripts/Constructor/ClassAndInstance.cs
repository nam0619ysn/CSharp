using UnityEngine;
namespace Constructor
{
    public class ClassAndInstance : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Dog happy = new Dog("해피");
            Debug.Log(happy.Cry());

            Dog worry = new Dog("워리");
            Debug.Log(worry.Cry());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
