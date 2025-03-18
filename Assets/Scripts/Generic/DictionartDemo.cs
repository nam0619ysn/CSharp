using UnityEngine;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public class DictionartDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IDictionary<string,string> data = new Dictionary<string,string>();

        data.Add("��", "����Ư����");
        data.Add("��", "������");

        data.Remove("��");

        data["��"] = "õȣ��";

        try
        {
            //data["��"] = "������";
            data.Add("��","������");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        foreach (KeyValuePair<string,string> item in data)
        {
            Debug.Log($"{item.Key}-{item.Value}");
        }

        Debug.Log(data["��"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
