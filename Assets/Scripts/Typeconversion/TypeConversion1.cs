using UnityEngine;

public class TypeConversion1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 12.34;

        int i = 1234;

        d = i;

        Debug.Log("암묵적 형식변환:" + d);

        d = 12.34;

        i = 1234;
        i = (int) d;
        Debug.Log("명시적 형식변환:" + i);

        d = 12.34;
        i = 1234;

        string s = "";
        s = i.ToString();
        Debug.Log("다른 형식변환:" + s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
