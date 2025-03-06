using UnityEngine;

public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     if(1==1)
     {
            Debug.Log("단문1");
     }

        if (1 == 1)
         Debug.Log("단문2");
        

        if (1 == 1) Debug.Log("단문3");


        if (1 == 1)
        {
            Debug.Log("복문1");
            Debug.Log("복문2");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
