using UnityEngine;

namespace Inheritence05
{
    public class BaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            new My().Run();
            new My("¾Æ¹Ýµ¥").Run();

        }


    }
}
