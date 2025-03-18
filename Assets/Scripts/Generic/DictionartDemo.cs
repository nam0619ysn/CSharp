using UnityEngine;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public class DictionartDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IDictionary<string,string> data = new Dictionary<string,string>();

        data.Add("시", "서울특별시");
        data.Add("구", "강동구");

        data.Remove("시");

        data["동"] = "천호동";

        try
        {
            //data["구"] = "강남구";
            data.Add("구","강남구");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        foreach (KeyValuePair<string,string> item in data)
        {
            Debug.Log($"{item.Key}-{item.Value}");
        }

        Debug.Log(data["구"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
