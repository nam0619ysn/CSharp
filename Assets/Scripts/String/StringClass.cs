using UnityEngine;

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "�ȳ��ϼ���";
        System.String s2="�ݰ����ϴ�";

        Debug.Log($"{s1}�� ����:{s1.Length},{s2}����:{s2.Length}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
