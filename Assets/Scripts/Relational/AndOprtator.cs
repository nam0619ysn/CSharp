using UnityEngine;

public class AndOprtator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(true && true);
        Debug.Log(true && false);
        Debug.Log(false && true);
        Debug.Log(false && false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
