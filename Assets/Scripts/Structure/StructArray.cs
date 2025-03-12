using UnityEngine;


struct UserInfo
{
    public string name;
    public int age;
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserInfo info;

        info.name = "ȣ�浿";
        info.age = 20;
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);
        UserInfo[] userInfos = new UserInfo[2];
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "���ǻ�";
        userInfos[1].age = 33;

        for(int i=0;i<=userInfos.Length;i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            PrintUserInfo(userInfos[i]);
        }
    }

    // Update is called once per frame
    void PrintUserInfo(string name,int age)
    {
        Debug.Log($"�̸�:{name} ����: {age}");
    }

    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"�̸�:{userInfo.name} ����: {userInfo.age}");
    }
}
