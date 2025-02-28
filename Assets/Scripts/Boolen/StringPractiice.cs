using UnityEngine;

public class StringPractiice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "È¦¼ö";
        
        const int AGE = 3;
        Debug.Log($"{AGE}Àº{name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
