using UnityEngine;

public class SharedAndInstance 
{
    public static void StaticMember() => Debug.Log("[1] Static Member");
    public  void InstanceMember() => Debug.Log("[1] InstanceMember");
}


public class StaticAndInstant : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SharedAndInstance.StaticMember();
        SharedAndInstance obj = new SharedAndInstance();
        obj.InstanceMember();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
