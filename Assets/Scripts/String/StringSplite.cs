using UnityEngine;

public class StringSplite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string scr = "Red,Green,Blue";

        string[] colors = scr.Split(',');

        for(int i =0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
