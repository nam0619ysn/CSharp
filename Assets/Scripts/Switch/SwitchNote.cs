using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 2;

        switch(x)
        {
            case 1:
                Debug.Log("x는 1이다");
                break;

            case 2:
                Debug.Log("x는 2다");
                break;

        }
        Debug.Log("프로그램 종료");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
