using UnityEngine;

public class StriingDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firtName = "�浿";
        var lastName = "ȫ";


        displayName = "�̸�:" + lastName + firtName;
        Debug.Log(displayName);

        displayName = string.Format("�̸�:{0}{1}",lastName,firtName);
        Debug.Log(displayName);

        displayName =$"�̸�:{lastName}{firtName}";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
