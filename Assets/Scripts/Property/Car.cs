using UnityEngine;
namespace Property
{
    public class Car
    {
        private string color;

        public Car()
        {
            this.color = "Black";
        }


        public void SetColor(string _color)
        {
            this.color = _color;

        }

        public string GetColor()
        {
            return this.color;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public string Maker
        {
            get
            {
                return "�����ڵ���";
            }
        }

        public string NAme { get; set; }

    }
}

       