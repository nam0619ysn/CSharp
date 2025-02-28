using UnityEngine;

public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "¹®ÀÚ¿­ º¸°ü¹ý";

        Debug.Log("Message" + message);
        Debug.Log($"Message:{message}");

        string msg = string.Format("{0}´Ô,{1}","È«±æµ¿","¾È³çÇÏ¼¼¿ä.");
        Debug.Log(msg);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
