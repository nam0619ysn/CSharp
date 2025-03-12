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
        myCard.name = "남ㅅㅡㅇ우";
        myCard.age = 20;
        myCard.address = "서우ㄹ시";

        Debug.Log($"이르ㅁ:{myCard.name}나이:{myCard.age}주소:{myCard.address}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
