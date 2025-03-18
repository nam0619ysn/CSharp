using UnityEngine;

namespace PrivatePublic { 
    
    public class VariableSvope : MonoBehaviour
    {

        string gloabalVariable = "전역 변수";
   
         void Start()
         {
            string localVariable = "지역변수";
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
