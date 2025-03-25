using UnityEngine;
namespace Interface
{
    public class IBattery
    {

    }
    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }
    public class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }
    public class HdCar
    {
        private IBattery battery;

        public HdCar(IBattery battery)
        {
            this.battery = battery;
        }
    } 
  //  public void Run()
  //      {


  //          Debug.Log($"{battery.GetName()}배터리를 장착한 차 달린다,");


  //      }
  //}
}