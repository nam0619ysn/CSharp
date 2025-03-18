using UnityEngine;


public class ClassCode
{

}

public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClassCode objectCode1 = new ClassCode();
        Debug.Log(objectCode1.GetHashCode());

        ClassCode objectCode2 = new ClassCode();
        Debug.Log(objectCode2.GetHashCode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
