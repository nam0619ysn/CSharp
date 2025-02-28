using UnityEngine;

public class integerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        int min = -2147483648;
        int max = 2147483647;
        Debug.Log("int 변수의 최소값:"+min);
        Debug.Log("int 변수의 최대값:" + max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
