using UnityEngine;
namespace Override
{
    public enum Cartype
    {
        전기,
        내연기관
    }
    public abstract class CarBase
    {

        public abstract void Left();

        public void Back() => Debug.Log("후진하다.");

        protected string LeftMessage { get;private set; } = "자회전 한다";
    }

    public class Car:CarBase
    {

        public Cartype Style { get;private set; }

        public Car(Cartype cTypye)
        {
            this.Style = cTypye;
        }

        public void Go() => Debug.Log("달린다");
        public override void Left()
        {
            Debug.Log(base.LeftMessage);
        }

        //public class HyunDai : Car
        //{
        //    public HyunDai():this.
        //    {

        //    }
        //    public HyunDai(Cartype cartype):base(carType) 
        //    { 
            
        //    }
        //}

    }
}