using UnityEngine;
namespace Constructor
{
    public class Money
    {
        public Money():this(1000)
        {
            Debug.Log("�⺻ ������ ����");
        }

        public Money(int gold)
        {
            Debug.Log($"Money:{gold:#,###}");
        }
    }
}