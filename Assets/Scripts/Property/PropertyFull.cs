using UnityEngine;
namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();

            person.SetName("ȫ�浿");
            Debug.Log( person.GetName());


            person.Name = "��λ�";
            Debug.Log(person.Name);
        }

        
    }
}