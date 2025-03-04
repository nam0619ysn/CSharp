using UnityEngine;

public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "ȫ�浿";
        Debug.Log(name);
        Debug.Log(name.GetType());
        var version=8.0;
        Debug.Log(version);
        Debug.Log(version.GetType());
        var car = 1;
        Debug.Log(car);
        Debug.Log(car.GetType());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
