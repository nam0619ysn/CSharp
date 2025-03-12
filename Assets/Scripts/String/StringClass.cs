using UnityEngine;

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "안녕하세요";
        System.String s2="반갑습니다";

        Debug.Log($"{s1}의 길이:{s1.Length},{s2}길이:{s2.Length}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
