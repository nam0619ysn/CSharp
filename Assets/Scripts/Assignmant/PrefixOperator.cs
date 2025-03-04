using UnityEngine;

public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = ++i;

        Debug.Log("J:" + j);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
