using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double pi = 3.141592;
        float f = 3.14f;
        decimal d = 12.34m;
        //Debug.Log(pi);
        //Debug.Log(f);
        //Debug.Log(d);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double �ּҰ�:"+doubleMin);
        Debug.Log("double �ִ밪:" + doubleMax);

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;

        Debug.Log("floa �ּҰ�:" + floatMin);
        Debug.Log("float �ִ밪:" + floatMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
