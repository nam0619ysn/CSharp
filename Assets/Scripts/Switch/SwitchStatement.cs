using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("������ �����Ӥ��Ѥ� ��ä�����.(����,��,�帲,��)");
        string weather = "�帲";

        switch (weather)
        {
            case "����":
                Debug.Log("���� ���� �����ϴ�");
                break;

            case "�帲":
                Debug.Log("���� ���� �帲�ϴ�");
                break;

            case "��":
                Debug.Log("���� ���� ��ɴϴ�");
                break;
            case "��":
                Debug.Log("���� ���� ���ɴϴ�");
                break;
        }
;    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
