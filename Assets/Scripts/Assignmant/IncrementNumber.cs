using UnityEngine;

public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 10;

        num = num + 1;
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
