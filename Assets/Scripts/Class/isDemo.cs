using UnityEngine;

public class isDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;
        Debug.Log(o);

        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);

        object s = "안녕하세요";
        object j = 4567;

        if (s is string)
        {
            Debug.Log($"[]j{s}안녕하세요는 null이 아니며 문자열 형식으로 변환.");
        }
        if (j is int)
        {
            Debug.Log($"[2]{j}정수변환");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
