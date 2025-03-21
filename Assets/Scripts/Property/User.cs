using UnityEngine;
namespace Property
{
    public class User
    {
        private int birthYear;

        public string Name { get; set; }

        public int BithYear
        {
            set
            {
                if(value >= 1900)
                {
                     birthYear = value;
                }
                else
                {
                    birthYear = 0;
                }
               
            }
        }

        public int Age
        {
            get
            {
                return System.DateTime.Now.Year - birthYear;
            }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
