using UnityEngine;

public class ReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string returnValue=GetString();
        Debug.Log(returnValue);
    }

    // Update is called once per frame
    string GetString()
    {
        return "¹ÝÈ¯°ª(Return Value)";
    }
}
