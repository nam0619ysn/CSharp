using UnityEngine;
namespace PrivatePublic
{
    public class Person
    {
        private string name = "ȫ�浿";
        private const int AGE = 21;
        private readonly string NickName = "������";

        private string[] address = { "����", "����", "��õ" };
        private object all = System.DateTime.Now.ToShortTimeString();


        public void ShowProfile()
        {
            Debug.Log($"�̸�:{name},����:{AGE},����:{NickName}");
        }

    }
}