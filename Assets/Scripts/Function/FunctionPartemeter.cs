using UnityEngine;

public class FunctionPartemeter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage("hello");
        ShowMessage("hi");
    }

    // Update is called once per frame
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
