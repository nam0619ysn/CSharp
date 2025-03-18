using UnityEngine;


public class My
{

}

public class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 저장";
    }
}
public class ToStringMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        My my = new My();

        Debug.Log(my);

        Your your = new Your();
        Debug.Log(your);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
