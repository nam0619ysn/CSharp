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
        //    message = "null�̸� ���ο� �� �ʱ�ȭ";
        //}

        message = nullValue ?? "null�̸� ���ο� �� �ʱ�ȭ";

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
        msg = "�ȳ��ϼ���?";
        len = msg?.Length;
        Debug.Log(len);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
