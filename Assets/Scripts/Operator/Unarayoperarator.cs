using UnityEngine;

public class Unarayoperarator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int value = 0;
        value = 8;
        value = +value;
        Debug.Log(value);

        value = -8;
        value = +value;
        Debug.Log(value);

        value = 8;
        value = -value;
        Debug.Log(value);

        value = -8;
        value = -value;
        Debug.Log(value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
