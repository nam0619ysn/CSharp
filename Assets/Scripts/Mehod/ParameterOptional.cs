using UnityEngine;
namespace Method
{
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(5));
        }

        int Add(int a,int b = 1)
        {
            return a + b;
        }
    }
}