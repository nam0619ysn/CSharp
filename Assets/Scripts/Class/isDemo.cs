using UnityEngine;

public class isDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;
        Debug.Log(o);

        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);

        object s = "�ȳ��ϼ���";
        object j = 4567;

        if (s is string)
        {
            Debug.Log($"[]j{s}�ȳ��ϼ���� null�� �ƴϸ� ���ڿ� �������� ��ȯ.");
        }
        if (j is int)
        {
            Debug.Log($"[2]{j}������ȯ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
