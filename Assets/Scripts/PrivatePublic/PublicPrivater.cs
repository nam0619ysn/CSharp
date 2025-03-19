using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
namespace PrivatePublic
{
    public class PublicPrivater
    {
        public static string name="Æ®·°";

        private int age;

        public static string GetName()
        {
            return name;
        }
        public void SetAge(int nai)
        {
            age=nai;
        }
        public int GetAge()
        {
            return age;
        }

    }
}
