using UnityEngine;
namespace Inheritence07
{
    public class Animal
    {
        public void Eat() => Debug.Log("���� �Ծ��");
    }

    public sealed class Cat : Animal
    {

    }

    //public class MyCat : Cat
    //{

    //}
}