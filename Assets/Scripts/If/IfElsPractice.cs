using UnityEngine;

public class IfElsPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("금매달");
        }
        else if (score >= 80)
        {
            Debug.Log("은매달");
        }
        else if (score >= 70)
        {
            Debug.Log("동매달");
        }
        else
        {
            Debug.Log("노매달");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
