using UnityEngine;
namespace Inheritence06
{
    public class Child:Parent
    {
        public Child() : this("Ȧ�浿")
        {

        }
        public Child(string message): base(message)
        {

        }

        public void SayName()
        {
            Debug.Log(base.Word);
        }
    }
}