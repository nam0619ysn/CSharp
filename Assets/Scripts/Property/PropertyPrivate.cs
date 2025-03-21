using UnityEngine;
namespace Property
{
    public class PropertyPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Page page = new Page();
            Debug.Log(page.Message);

            User user = new User("홍길도");
            user.BithYear = 2002;
            Debug.Log($"이름:{user.Name} 나이:{user.Age}");
        }

       
    }
}
