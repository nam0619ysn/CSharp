using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        long l = long.MaxValue;
        Debug.Log("l�ǰ�:"+ l);

        int i = (int)l;
        Debug.Log("i�� ��:"+i);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
