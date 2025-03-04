using UnityEngine;

public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("x:" + x);
        Debug.Log("y:" + y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
