using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
namespace Inheritence10
{
    public class Squre:Shape
    {
        private int size;

        public Squre(int _size)
        {
            this.size = _size;
        }

        public override double GetArea()
        {
            return size * size;
        }
    }
}