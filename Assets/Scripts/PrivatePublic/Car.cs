using UnityEngine;
namespace PrivatePublic
{
    public class Car : MonoBehaviour
    {
        public string name;
        private int age;
        string address;

        public void Hi()
        {
            Debug.Log("�ȳ��ϼ���");
        }

        private void Bye()
        {
            Debug.Log("�ȳ��� �輼��");
        }
    }
}
