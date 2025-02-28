using UnityEngine;

public class ReallNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float fl = 3.14F;
        double dl=3.14D;
        decimal dcl = 3.14M;

        Debug.Log(fl);
        Debug.Log(dl);
        Debug.Log(dcl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
