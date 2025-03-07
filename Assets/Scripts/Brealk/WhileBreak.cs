using UnityEngine;

public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            if (sum >= goal)
            {
                break;
            }
            i++;
        }
        Debug.Log($"1~{n}±îÁö ÇÕ:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
