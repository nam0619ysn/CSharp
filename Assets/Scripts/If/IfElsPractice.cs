using UnityEngine;

public class IfElsPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("�ݸŴ�");
        }
        else if (score >= 80)
        {
            Debug.Log("���Ŵ�");
        }
        else if (score >= 70)
        {
            Debug.Log("���Ŵ�");
        }
        else
        {
            Debug.Log("��Ŵ�");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
