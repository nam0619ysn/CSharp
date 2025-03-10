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

        PrintError("디버그", 4);
        PrintError("디버그");
    }

    // Update is called once per frame
    void PrintMessage()
    {

        string message = "Debug";
        Debug.Log(message);
    }

    void PrintError(string message,int level =1)
    {
        Debug.Log($"ERROR:{message},레벨:{level}");
    }
    //void PrintLog()
    //{
    //    string log="디버그로그";

    //return
    //}
}
