using UnityEngine;
namespace Override
{
    public class Developer:System.Object
    {
        public override string ToString()
        {
            return "개발자";
        }

        public class WebDeveloper : Developer
        {
            public override string ToString()
            {
                return "웹개발자";
            }
        }
        public class MobileDeveloper : Developer
        {
            public override string ToString()
            {
                return "모바일개발자";
            }
        }
    }
}
