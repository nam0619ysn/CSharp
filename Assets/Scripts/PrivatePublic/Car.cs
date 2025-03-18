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
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }
    }
}
