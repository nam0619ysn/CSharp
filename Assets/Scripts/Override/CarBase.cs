using UnityEngine;
namespace Override
{
    public enum Cartype
    {
        ����,
        �������
    }
    public abstract class CarBase
    {

        public abstract void Left();

        public void Back() => Debug.Log("�����ϴ�.");

        protected string LeftMessage { get;private set; } = "��ȸ�� �Ѵ�";
    }

    public class Car:CarBase
    {

        public Cartype Style { get;private set; }

        public Car(Cartype cTypye)
        {
            this.Style = cTypye;
        }

        public void Go() => Debug.Log("�޸���");
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