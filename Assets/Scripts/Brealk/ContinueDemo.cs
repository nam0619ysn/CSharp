using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            sum += i;
        }
        Debug.Log($"1~{n}���� 3�� ��� ������:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
