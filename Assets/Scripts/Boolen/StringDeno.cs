using UnityEngine;

public class StringDeno : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿";
        Debug.Log("�ȳ��ϼ���"+ name +"�Դϴ�");

        string multiLine = @"
        �ȳ��ϼ���
        �ݰ����ϴ�.";

        Debug.Log(multiLine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
