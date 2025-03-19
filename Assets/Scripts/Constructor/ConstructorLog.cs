using UnityEngine;
namespace Constructor
{
    public class ConstructorLog : MonoBehaviour
    {
        public ConstructorLog()
        {
            Debug.Log("기본생성자 호출");
        }
        public ConstructorLog(string message)
        {
            Debug.Log($"오버로드 된 생성자 실행:{message}");
        }
        
    }
}
