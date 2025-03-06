using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 4 == 0) // 3의 배수 또는 4의 배수인 경우
            {
                sum += i;
            }
        }

        Debug.Log($"합은 {sum}");


        // Update is called once per frame
        void Update()
        {

        }
    }
}
