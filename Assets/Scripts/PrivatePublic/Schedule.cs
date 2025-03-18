using UnityEngine;

namespace PrivatePublic
{ 


    public class Schedule
    {

        string[] weekDays = { "Sun","Mon","Tue","Wen","Thu","Fri","Sat"};


        public void PrintWeekDays()
        {
            for(int i=0; i< weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }
    }


}

