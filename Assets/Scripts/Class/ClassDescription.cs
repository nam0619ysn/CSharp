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
        Debug.Log("ClassDescription라느 클래스의 Run 메서드");
    }
}
