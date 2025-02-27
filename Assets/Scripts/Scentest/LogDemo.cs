using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

//Log:
public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");

        UnityEngine.Debug.Log("Hello Unity");

        Debug.Log("결과는:"+5);
        Debug.Log("결과는:" + (5+10));
        Debug.Log("결과는:" + 5+10);
    }

    
}
