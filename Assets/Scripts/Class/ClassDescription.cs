using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run();
       ClassDescription.Run();
    }

    // Update is called once per frame
    static void Run()
    {
        Debug.Log("ClassDescription��� Ŭ������ Run �޼���");
    }
}
