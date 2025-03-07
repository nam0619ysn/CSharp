using UnityEngine;

public class BreakInfinite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 0;

        while(true)
        {
            Debug.Log(number);
            number++;
            if (number >= 5)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
