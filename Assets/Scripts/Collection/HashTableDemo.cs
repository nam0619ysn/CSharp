using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hashtable hash = new Hashtable();

        hash[0] = "���ѹα�";
        hash["���̸�"] = "����Ư����";
        hash["���̸�"] = "������";

        //Debug.Log(hash[0]);
        //Debug.Log(hash["���̸�"]);
        //Debug.Log(hash["���̸�"]);

        foreach(var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()}-{hash[o]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
