using UnityEngine;

namespace PrivatePublic { 
    
    public class VariableSvope : MonoBehaviour
    {

        string gloabalVariable = "���� ����";
   
         void Start()
         {
            string localVariable = "��������";
            Debug.Log(localVariable);

            Debug.Log(gloabalVariable);

            TestPrint();
        }

         void TestPrint()
         {
            //Debug.Log(loacalVariable);
            Debug.Log(gloabalVariable);
        }   
   
    }
}
