using UnityEngine;
namespace Override
{
    public class Parents
    {
        public void Say() => Debug.Log("부모 안녕하세요");
        public void Run() => Debug.Log("부모 달린다");
        public virtual void Walk() => Debug.Log("부모 걷다");
    }

    public class Child : Parents
    {
        public void Say() => Debug.Log("자식 안녕하세요");
        public new void Run() => Debug.Log("자식 달린다");

        public override void Walk() => Debug.Log("자식 걷다");
    }
    
}