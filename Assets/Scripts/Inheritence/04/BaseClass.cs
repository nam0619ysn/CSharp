using UnityEngine;
namespace Inheritence04
{
    public class BaseClass: System.Object
    {
        protected void PrintLog()
        {
            Debug.Log("부모 클레스의 메서드 호출");
        }
    }
}