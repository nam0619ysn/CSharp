using UnityEngine;
namespace Inheritence09
{
    public class INheritenceMustDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person =new Person();
            person.SayTalk();
        }

        
    }
}
