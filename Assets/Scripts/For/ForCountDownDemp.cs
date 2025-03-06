using UnityEngine;

public class ForCountDownDemp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=1; i<5+1;i++)
        {
            Debug.Log($"증가 Countdown:{i}");
        }
        Debug.Log("=====================================");

        //for (int i = 5; i > 1-1; i--)
        //{
        //    Debug.Log($"감소 Countdown:{i}");
        //}
        for(int i= 0; i<5;i++)
        {
            Debug.Log($"감소 Countdown:{5-i}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
