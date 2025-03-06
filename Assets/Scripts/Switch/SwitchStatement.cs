using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("¿À´À¤© ³¯¤¶¤Ó¤¤¤Ñ¤¤ ¾î¤¨¤Ã¤¤°¡¿ä.(¸¼À½,ºñ,Èå¸²,´«)");
        string weather = "Èå¸²";

        switch (weather)
        {
            case "¸¼À½":
                Debug.Log("¿À´Ã ³¯¾¾ ¸¼½À´Ï´Ù");
                break;

            case "Èå¸²":
                Debug.Log("¿À´Ã ³¯¾¾ Èå¸²´Ï´Ù");
                break;

            case "ºñ":
                Debug.Log("¿À´Ã ³¯¾¾ ºñ¿É´Ï´Ù");
                break;
            case "´«":
                Debug.Log("¿À´Ã ³¯¾¾ ´«¿É´Ï´Ù");
                break;
        }
;    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
