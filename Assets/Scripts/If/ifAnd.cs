using UnityEngine;

public class ifAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number=1234;

        if (number ==1234 && number>=1000)
        {
            Debug.Log("맞습니다.");
        }

        if (number == 1234 || number <= 1000)
        {
            Debug.Log("하라도참이라면 참.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
