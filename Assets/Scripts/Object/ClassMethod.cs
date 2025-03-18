using UnityEngine;

public class MyMath
{
    public void Sum(int x, int y)
    {
        int sum = x + y;
        Debug.Log($"гу╟Х:{sum}");
    }
}
public class ClassMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyMath myMath = new MyMath();

        myMath.Sum(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
