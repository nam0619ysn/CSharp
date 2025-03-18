using UnityEngine;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { 90, 65, 78, 50, 95 };

        double average = 0;
        int sum = 0;
        int count = 0;

        for(int i=0; i < data.Length; i++)
        {
            if (data[i] >= 70 && data[i] <= 95) 
                            
            {
                sum = sum + data[i];
                count++;
            }
        }
        if (count > 0)
        {
            average = sum / (double)count;
        }


     
        Debug.Log($"ЦђБе::{average:#.##}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
