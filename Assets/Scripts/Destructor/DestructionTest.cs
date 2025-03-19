using UnityEngine;
namespace Constructor
{
    public class DestructionTest 
    {
        public DestructionTest()
        {
            Debug.Log("[1]积己");
        }

        public void Run()
        {
            Debug.Log("[2] 角青");
        }

        ~DestructionTest()
        {
            Debug.Log("[3] 家戈");
        }
    }
}
