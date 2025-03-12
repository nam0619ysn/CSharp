using UnityEngine;



public class DateTmeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"현재시간:{System.DateTime.Now}");

        Debug.Log(System.DateTime.Now.Year);
        Debug.Log(System.DateTime.Now.Month);
        Debug.Log(System.DateTime.Now.Date);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);


        System.DateTime now = System.DateTime.Now;
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
