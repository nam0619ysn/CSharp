using UnityEngine;
using static Override.Developer;
namespace Override
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Developer dev = new Developer();
            Debug.Log(dev);

            WebDeveloper webdeveloper = new WebDeveloper();
            Debug.Log(webdeveloper);  
            MobileDeveloper mobildeveloper = new MobileDeveloper();
            Debug.Log(mobildeveloper);
        }

        
    }
}