using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        int answer=1;


        if (answer == 1)
        {
            Debug.Log("1 ����");
        }
        else if (answer == 2)
        {
            Debug.Log("2 ����");
        }
        else if (answer == 3)
        {
            Debug.Log("3 ����");
        }
        else if (answer == 4)
        {
            Debug.Log("4 ����");
        }
        else if (answer == 5)
        {
            Debug.Log("5 ����");
        }
        else
        {
            Debug.Log("�߸� ����");
        }

        //switch (answer)
        //{
        //    case 1:
        //        Debug.Log("1 ����");
        //        break;

        //    case 2:
        //        Debug.Log("2 ����");
        //        break;

        //    case 3:
        //        Debug.Log("3 ����");
        //        break;

        //    case 4:
        //        Debug.Log("4 ����");
        //        break;
        //    case 5:
        //        Debug.Log("5 ����");
        //        break;          
        //}
        //Debug.Log("�߸� ����");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
