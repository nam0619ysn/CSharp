using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        long l = long.MaxValue;
        Debug.Log("l의값:"+ l);

        int i = (int)l;
        Debug.Log("i의 값:"+i);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
