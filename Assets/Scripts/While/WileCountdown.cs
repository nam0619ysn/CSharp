using UnityEngine;

public class WileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        while(i<=5)
        {
            Debug.Log($"카운트다운:{i}");
            i++;
        }
        Debug.Log("==============================================");

        int r = 5;
        while (r >= 1)
        {
            Debug.Log($"카운트다운:{r}");
            r--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
