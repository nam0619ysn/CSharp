using UnityEngine;
namespace Delegate
{
    public class CarDriver : MonoBehaviour
    {
        public static void GoForward()
        {
            Debug.Log("����");
        }
        public static void GoLeft()
        {
            Debug.Log("��ȸ��");
        }
        public static void GoRight()
        {
            Debug.Log("��ȸ��");
        }
    }
}