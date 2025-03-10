using UnityEngine;

public class SrrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            

            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    intArray[i, j]= 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }
                
            }

        }

        for (int i = 0; i < 3; i++)
        {


            for (int j = 0; j < 3; j++)
            {
                
                Debug.Log($"arr{i}{j}:{intArray[i, j]}");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
