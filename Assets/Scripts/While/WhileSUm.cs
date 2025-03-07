using UnityEngine;

public class WhileSUm : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            
            i++;
        }
        Debug.Log($"1~{n}±îÁö ÇÕ:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
