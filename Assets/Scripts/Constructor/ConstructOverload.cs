using UnityEngine;
namespace Constructor
{
    public class ConstructOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ConstructorLog log1 = new ConstructorLog();
            ConstructorLog log2 = new ConstructorLog("ȫ�浿");
            ConstructorLog log3 = new ConstructorLog("��λ�");

        }


    }
}
