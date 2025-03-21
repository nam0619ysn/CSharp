using UnityEngine;
namespace Override
{
    public class Parents
    {
        public void Say() => Debug.Log("�θ� �ȳ��ϼ���");
        public void Run() => Debug.Log("�θ� �޸���");
        public virtual void Walk() => Debug.Log("�θ� �ȴ�");
    }

    public class Child : Parents
    {
        public void Say() => Debug.Log("�ڽ� �ȳ��ϼ���");
        public new void Run() => Debug.Log("�ڽ� �޸���");

        public override void Walk() => Debug.Log("�ڽ� �ȴ�");
    }
    
}