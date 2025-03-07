using UnityEngine;

public class breakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0; i<5; i++)
        {
            Debug.Log("¾È³çÇÏ¼¼¿ä");

            if(i==2)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
