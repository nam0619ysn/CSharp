
using UnityEngine;
namespace Property
{
    public class PropertyDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Developer dev = new Developer();

            dev.Name = "ȫ�浿";

            Debug.Log(dev.Name);
        }

        
    }
}