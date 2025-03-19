using UnityEngine;
namespace Constructor
{
    public class ConstructorDescription : MonoBehaviour
    {

        public ConstructorDescription()
        {

        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ConstructorDescription cons = new ConstructorDescription();
        }

        
    }
}
