using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("�ݰ����ϴ�.");
        Hi("�����մϴ�.", 3);
    }

    // Update is called once per frame
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���");
    }

    void Hi(string message)
    {
        Debug.Log(message);
    }
    void Hi(string message,int count)
    {
        for(int i=0; i<count; i++)
        {
            Debug.Log(message);
        }
    }


}
