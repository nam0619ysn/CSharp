using UnityEngine;


struct BusinessCard
{
    public string name;
    public int age;
    public string address;
}
public class structNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BusinessCard myCard;
        myCard.name = "�����Ѥ���";
        myCard.age = 20;
        myCard.address = "���줩��";

        Debug.Log($"�̸���:{myCard.name}����:{myCard.age}�ּ�:{myCard.address}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
