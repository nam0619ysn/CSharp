using UnityEngine;
namespace Indexer
{
    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car car = new Car(3);
            car[0] = "���׽ý�";
            car[1] = "�׷���";
            car[2] = "�ƹ���";

            //for(int i=0; i<= car.Length; i++)
            //{
            //    Debug.Log(car[i]);
            //}

            foreach(var c in car)
            {
                Debug.Log(c);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}