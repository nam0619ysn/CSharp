using UnityEngine;

public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        for(int i=1; i< n+1;i++)
        {
            sum = sum + i;
        }
        Debug.Log($"���� {sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
