using UnityEngine;
namespace Constructor
{
    public class DestructuorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            DestructionTest destructionTest = new DestructionTest();

            destructionTest.Run();
            
            
        }
        

    }
}
