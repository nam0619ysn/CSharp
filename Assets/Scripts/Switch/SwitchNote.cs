using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 2;

        switch(x)
        {
            case 1:
                Debug.Log("x�� 1�̴�");
                break;

            case 2:
                Debug.Log("x�� 2��");
                break;

        }
        Debug.Log("���α׷� ����");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
