using System.Linq;
using UnityEngine;

public class LinCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool[] blns = { true, false, true, false, true };

        Debug.Log(blns.Count());
        Debug.Log(blns.Count(b => b == true));
        Debug.Log(blns.Count(b => b == false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
