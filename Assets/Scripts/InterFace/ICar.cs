using UnityEngine;
namespace Interface
{
    public interface ICar
    {
        void Go();
    }

    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("성수한 모임");
        }
    }
}