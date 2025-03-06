using UnityEngine;

public class EldeNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            Debug.Log("조건식이 참이면 실행문1 입니다.");
        }
        else 
        {
            Debug.Log("조건식이 거짖이면 실행문 2입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
