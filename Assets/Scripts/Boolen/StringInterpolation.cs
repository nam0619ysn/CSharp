using UnityEngine;

public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "���ڿ� ������";

        Debug.Log("Message" + message);
        Debug.Log($"Message:{message}");

        string msg = string.Format("{0}��,{1}","ȫ�浿","�ȳ��ϼ���.");
        Debug.Log(msg);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
