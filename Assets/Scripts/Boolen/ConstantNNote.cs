using UnityEngine;

public class ConstantNNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        name = "이순신";
        const int AGE = 20;
        Debug.Log($"{name}-{AGE}");
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
