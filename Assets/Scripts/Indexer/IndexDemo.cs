using UnityEngine;
namespace Indexer
{
    public class IndexDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            person[0] = "ȫ�浿";
            Debug.Log(person[0]);

            person[1] = "��λ�";
            Debug.Log(person[1]);

            Debug.Log(person[0]);
        }

        
    }
}