using UnityEngine;

public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        double d = 3.14;
        string s = "�ȳ��ϼ���.";
        char c='A';

        Debug.Log(i.GetType());
        Debug.Log(d.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
