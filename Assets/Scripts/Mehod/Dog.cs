using UnityEngine;
namespace Method
{
    public class Dog : MonoBehaviour
    {
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1] 밥을 머는다");
        }

        public void Drinkt()
        {
            Debug.Log("[2] 물을 마신다");
        }

        private void Digest()
        {
            Debug.Log("[3] 소화시킨다");
        }
    }
}