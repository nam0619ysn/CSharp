using UnityEngine;
namespace Property
{

    public class Truck
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color { get; set; }
        public int Number { get; set; } = 1234;
    }
}
