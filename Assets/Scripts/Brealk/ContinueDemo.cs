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
        Debug.Log($"1~{n}까지 3의 배수 제외합:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
