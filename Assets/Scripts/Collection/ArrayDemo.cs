using Unity.VisualScripting;
using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] colors = {"red", "green", "blue"};
        Debug.Log($"�迭�� ��Ҽ� ����:{colors.Length}");
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
