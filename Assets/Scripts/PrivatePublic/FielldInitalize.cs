using UnityEngine;
namespace PrivatePublic 
{ 
    public class FielldInitalize : MonoBehaviour
    {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Say say = new Say();

            say.Hi();
        }

  
    
    }
}

