using UnityEngine;

enum Priority
{
    High,
    Normal,
    Low,
}

public class EnumDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Debug.Log($"{high},{normal},{low}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
