using UnityEngine;
namespace Constructor
{
    public class ConstructorLog : MonoBehaviour
    {
        public ConstructorLog()
        {
            Debug.Log("�⺻������ ȣ��");
        }
        public ConstructorLog(string message)
        {
            Debug.Log($"�����ε� �� ������ ����:{message}");
        }
        
    }
}
