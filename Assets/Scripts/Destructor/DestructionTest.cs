using UnityEngine;
namespace Constructor
{
    public class DestructionTest 
    {
        public DestructionTest()
        {
            Debug.Log("[1]����");
        }

        public void Run()
        {
            Debug.Log("[2] ����");
        }

        ~DestructionTest()
        {
            Debug.Log("[3] �Ҹ�");
        }
    }
}
