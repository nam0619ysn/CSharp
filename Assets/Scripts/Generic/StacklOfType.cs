using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class StacklOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("10");
        stack.Push("TEN");

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
