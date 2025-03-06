using UnityEngine;

public class ForSumEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;

        for (int i = 2; i <=10; i+=2)
        {
            sum = sum + i;
            

        }
        Debug.Log($"гую╨ {sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
