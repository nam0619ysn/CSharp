using UnityEngine;

public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPlus";

        if (userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1]같습니다");
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
