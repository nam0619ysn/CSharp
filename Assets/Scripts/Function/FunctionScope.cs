using UnityEngine;

public class FunctionScope : MonoBehaviour
{
    string message = "��������";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage();
        PrintMesssage();
        Debug.Log(message);
    }

    // Update is called once per frame
    void ShowMessage()
    {
        string message = "��������";
        Debug.Log(message);
    }
   void PrintMesssage()
   {
      
        Debug.Log(message);
   }
}
