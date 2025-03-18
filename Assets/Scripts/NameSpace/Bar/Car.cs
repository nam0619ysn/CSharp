using UnityEngine;

namespace Bar
{
    public class Car : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void Go()
        {
            Debug.Log("Bar 네임 스페이스의 Car 클래스 호출");
        }


    }
}
