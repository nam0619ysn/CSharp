using UnityEngine;
using UnityEngine.UIElements;

public class VariableDefault : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = default;
        double d = default;
        char c = default;
        string s = default;
        //Debug.Log($"[{i}],[{d}],[{c}],[{s}]");
        Debug.Log($"[{i}],[{d}],[{c==System.Char.MinValue}],[{s==null}]");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
