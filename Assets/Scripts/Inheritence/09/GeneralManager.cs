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
            Debug.Log("��ӹ޾� ����ϴ� �޼ҵ�");
        }
    }
}