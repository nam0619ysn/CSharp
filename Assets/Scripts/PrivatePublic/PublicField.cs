using UnityEngine;
namespace PrivatePublic
{
    public class PublicField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Categori book = new Categori();

            book.CatrgoriName = "å";

            Debug.Log(book.CatrgoriName);
        }

        
    }
}
