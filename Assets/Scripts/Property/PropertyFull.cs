using UnityEngine;
namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();

            person.SetName("홍길동");
            Debug.Log( person.GetName());


            person.Name = "백두산";
            Debug.Log(person.Name);
        }

        
    }
}