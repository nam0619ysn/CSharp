using UnityEngine;
namespace Method
{
    public class Dog : MonoBehaviour
    {
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1] ���� �Ӵ´�");
        }

        public void Drinkt()
        {
            Debug.Log("[2] ���� ���Ŵ�");
        }

        private void Digest()
        {
            Debug.Log("[3] ��ȭ��Ų��");
        }
    }
}