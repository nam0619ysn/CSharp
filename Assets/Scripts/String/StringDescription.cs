using UnityEngine;

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "hello World!";
        Debug.Log(message);

        Debug.Log(message.ToLower());

        Debug.Log(message.ToUpper());

        Debug.Log(message.Replace("hello","�ȳ�������").Replace("World","����"));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
