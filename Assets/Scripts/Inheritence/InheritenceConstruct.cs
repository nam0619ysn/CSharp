using UnityEngine;
namespace Inheritence06
{
    public class InheritenceConstruct : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Child child1 = new Child();
            child1.SayName();

            Child child2 = new Child("��λ�");
            child2.SayName();
        }

        
    }
}