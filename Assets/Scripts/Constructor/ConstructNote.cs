using UnityEngine;
namespace Constructor
{
    public class ConstructNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person saram1 = new Person();

            Debug.Log(saram1.GetName());

            Person saram2 = new Person();
            Debug.Log(saram2.GetName());

            Person person1 = new Person("백두산");
            Debug.Log(person1.GetName());
            Person person2 = new Person("장길산");
            Debug.Log(person2.GetName());

        }

        
    }
}
