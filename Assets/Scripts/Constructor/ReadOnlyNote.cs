using UnityEngine;
namespace Constructor
{
    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            WithService file = new WithService("[1] file로그파일");
            file.Run();

            WithService db = new WithService("[2] db로그파일");
            db.Run();

        }


    }
}
