using UnityEngine;
namespace GenericClass
{
    public class Helllo<T>
    {
        private T _message;

        public Helllo()
        {
            this._message = default(T);
        }

        public Helllo(T message)
        {
           this._message = message;
        }

        public void Say(T message)
        {
            Debug.Log($"{message}");
        }

        public T GetMessage() => this._message;
    }
}
