using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        if (score >= 60)
        {
            Debug.Log("�հ�");

        }
        else
        {
            Debug.Log("���հ��Դϴ�.");
        
        }
        Debug.Log("����");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
