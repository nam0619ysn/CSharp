using System.Collections;
using UnityEngine;

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ArrayList list = new ArrayList();

        list.Add("���� Ư����");
        list.Add("������");

        for(int i=0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
