using UnityEngine;

public class StringPractiice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "Ȧ��";
        
        const int AGE = 3;
        Debug.Log($"{AGE}��{name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
