using UnityEngine;

public class StriingDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firtName = "길동";
        var lastName = "홍";


        displayName = "이름:" + lastName + firtName;
        Debug.Log(displayName);

        displayName = string.Format("이름:{0}{1}",lastName,firtName);
        Debug.Log(displayName);

        displayName =$"이름:{lastName}{firtName}";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
