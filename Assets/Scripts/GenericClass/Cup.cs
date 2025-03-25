using UnityEngine;

namespace GenericClass
{
    public class Water {}
    public class Coffe {}
    public class Cup<T>
    {
        public T Content { get; set; }

        //public Water Content { get; set; }
        public void PrintData(T data)
        {
            Debug.Log($"{data}");
        }
    }
}