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

            User user = new User("ȫ�浵");
            user.BithYear = 2002;
            Debug.Log($"�̸�:{user.Name} ����:{user.Age}");
        }

       
    }
}
