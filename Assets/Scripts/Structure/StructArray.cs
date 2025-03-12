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

        info.name = "호길동";
        info.age = 20;
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);
        UserInfo[] userInfos = new UserInfo[2];
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;
        userInfos[1].name = "설악산";
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
        Debug.Log($"이름:{name} 나이: {age}");
    }

    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"이름:{userInfo.name} 나이: {userInfo.age}");
    }
}
