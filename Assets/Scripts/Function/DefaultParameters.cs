using UnityEngine;

public class DefaultParameters : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PrintMessage();

        //string eror = "Debug";

        //PrintError(eror);

        //string errorLog = printLog();
        //Debug.Log(errorLog);

        PrintError("�����", 4);
        PrintError("�����");
    }

    // Update is called once per frame
    void PrintMessage()
    {

        string message = "Debug";
        Debug.Log(message);
    }

    void PrintError(string message,int level =1)
    {
        Debug.Log($"ERROR:{message},����:{level}");
    }
    //void PrintLog()
    //{
    //    string log="����׷α�";

    //return
    //}
}
