using UnityEngine;
namespace Inheritence04
{
    public class InheritenceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();
            Debug.Log(parent.ToString());

            ChildClass child = new ChildClass();
            child.PrintMessage2();


            SubClass sub = new SubClass();
            sub.PrintDebug();

        }

        
    }
}