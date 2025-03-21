using UnityEngine;
namespace Indexer
{
    public class InsexerDescriprion : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Catalog ca = new Catalog();
            Debug.Log(ca[0]);
            Debug.Log(ca[1]);
            Debug.Log(ca[2]);
            Debug.Log(ca[99]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}