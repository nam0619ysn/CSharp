using UnityEngine;
namespace Inheritence09
{
    public abstract class GeneralManager
    {
        public abstract void SayTalk();
       
    }

    public class Person : GeneralManager
    {
        public override void SayTalk()
        {
            Debug.Log("상속받아 출력하는 메소드");
        }
    }
}