using UnityEngine;

public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string nullValue = null;
        string message = "";

        //if (nullValue == null)
        //{
        //    message = "null이면 새로운 값 초기화";
        //}

        message = nullValue ?? "null이면 새로운 값 초기화";

        Debug.Log(message);

        int? len;
        string msg = null;

        //if(msg != null)
        //{
        //    len = msg.Length;
        //}
        //else
        //{
        //    len = null;
        //}

        len = msg?.Length;
        msg = "안녕하세요?";
        len = msg?.Length;
        Debug.Log(len);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
