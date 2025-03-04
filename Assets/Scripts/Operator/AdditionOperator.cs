using UnityEngine;

public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello"+"World");
        Debug.Log("Hi"+""+"Everyone");

        Debug.Log("123"+"456");
        Debug.Log("123" + 456);

        Debug.Log(123 + "456"+789+890);
        Debug.Log(123 + 456);

        Debug.Log("123" + true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
