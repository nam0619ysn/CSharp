using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        if (score >= 60)
        {
            Debug.Log("합격");

        }
        else
        {
            Debug.Log("불합격입니다.");
        
        }
        Debug.Log("종료");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
