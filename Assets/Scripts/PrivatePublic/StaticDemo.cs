using UnityEngine;
namespace PrivatePublic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            PublicPrivater.name = "ȫ�浿";
            //Debug.Log(PublicPrivater.name);
            string sName = PublicPrivater.GetName();
            Debug.Log(sName);

            PublicPrivater publicPrivater = new PublicPrivater();
            publicPrivater.SetAge(22);
            int MyAge=publicPrivater.GetAge();
            Debug.Log(MyAge);
        }

      
    }
}
