using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        int answer=1;


        if (answer == 1)
        {
            Debug.Log("1 선택");
        }
        else if (answer == 2)
        {
            Debug.Log("2 선택");
        }
        else if (answer == 3)
        {
            Debug.Log("3 선택");
        }
        else if (answer == 4)
        {
            Debug.Log("4 선택");
        }
        else if (answer == 5)
        {
            Debug.Log("5 선택");
        }
        else
        {
            Debug.Log("잘못 선택");
        }

        //switch (answer)
        //{
        //    case 1:
        //        Debug.Log("1 선택");
        //        break;

        //    case 2:
        //        Debug.Log("2 선택");
        //        break;

        //    case 3:
        //        Debug.Log("3 선택");
        //        break;

        //    case 4:
        //        Debug.Log("4 선택");
        //        break;
        //    case 5:
        //        Debug.Log("5 선택");
        //        break;          
        //}
        //Debug.Log("잘못 선택");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
