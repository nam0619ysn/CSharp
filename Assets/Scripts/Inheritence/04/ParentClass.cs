using UnityEngine;

namespace Inheritence04
{
    public class ParentClass :System.Object
    {
        protected void PrintMessage()
        {
            Debug.Log("부모 클래스에서 정의환 내용");
        }
    }
}