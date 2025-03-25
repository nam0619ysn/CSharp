using UnityEngine;
namespace Override
{
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();
        }
        void PritNumber(int number) => Debug.Log($"{number}");   
        void PritNumber(double number) => Debug.Log($"{number}");   
        void PritNumber(int a,int b) => Debug.Log($"{a+b}");   
    }
}