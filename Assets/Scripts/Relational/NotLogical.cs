using UnityEngine;

public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(!true);

        Debug.Log(!false);

        bool bln = false;
        Debug.Log(!bln);
        Debug.Log(!!bln);
        Debug.Log((!!(!(bln))));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
