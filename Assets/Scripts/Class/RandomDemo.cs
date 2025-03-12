using UnityEngine;

public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();

        Debug.Log(random.Next());

        Debug.Log(random.Next(5));
        Debug.Log(random.Next(1,10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
