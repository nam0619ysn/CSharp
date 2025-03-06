using UnityEngine;

public class RelationalOPerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);
        Debug.Log(x > y);
        Debug.Log(x == y);
        Debug.Log(x != y);
        Debug.Log(x <= y);
        Debug.Log(x >= y);

        Debug.Log("AAA" == "aaa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
