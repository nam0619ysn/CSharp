using UnityEngine;
namespace Constructor
{
    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            WithService file = new WithService("[1] file�α�����");
            file.Run();

            WithService db = new WithService("[2] db�α�����");
            db.Run();

        }


    }
}
