using UnityEngine;

public class ForFactoriall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 4;
        int fact = 1;
        for(int i=1; i < n+1; i++)
        {
            fact = fact * i;
        }

        Debug.Log($"4! °ªÀº{fact}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
