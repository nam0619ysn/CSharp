using UnityEngine;

public class ifAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number=1234;

        if (number ==1234 && number>=1000)
        {
            Debug.Log("�½��ϴ�.");
        }

        if (number == 1234 || number <= 1000)
        {
            Debug.Log("�϶����̶�� ��.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
