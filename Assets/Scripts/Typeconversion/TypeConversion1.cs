using UnityEngine;

public class TypeConversion1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 12.34;

        int i = 1234;

        d = i;

        Debug.Log("�Ϲ��� ���ĺ�ȯ:" + d);

        d = 12.34;

        i = 1234;
        i = (int) d;
        Debug.Log("����� ���ĺ�ȯ:" + i);

        d = 12.34;
        i = 1234;

        string s = "";
        s = i.ToString();
        Debug.Log("�ٸ� ���ĺ�ȯ:" + s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
