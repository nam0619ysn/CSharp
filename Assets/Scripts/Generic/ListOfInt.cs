using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arrNumbers = new int[2];

        arrNumbers[0] = 10;
        arrNumbers[1] = 20;

        for(int i=0; i< arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }
        //arrNumbers[2] = 30;
        //for (int i = 0; i < arrNumbers.Length; i++)
        //{
        //    Debug.Log(arrNumbers[i]);
        //}

        List<int> lstNUmbers = new List<int>();

        lstNUmbers.Add(30);
        lstNUmbers.Add(40);

        for (int i = 0; i < lstNUmbers.Count; i++)
        {
            Debug.Log(lstNUmbers[i]);
        }
        lstNUmbers.Add(50);
        for (int i = 0; i < lstNUmbers.Count; i++)
        {
            Debug.Log(lstNUmbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
