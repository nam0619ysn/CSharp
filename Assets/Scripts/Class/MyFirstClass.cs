using UnityEngine;

public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClassMembers.StaticMethod();

        ClassMembers members = new ClassMembers();
        members.InstantceMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
