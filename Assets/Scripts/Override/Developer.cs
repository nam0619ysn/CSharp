using UnityEngine;
namespace Override
{
    public class Developer:System.Object
    {
        public override string ToString()
        {
            return "������";
        }

        public class WebDeveloper : Developer
        {
            public override string ToString()
            {
                return "��������";
            }
        }
        public class MobileDeveloper : Developer
        {
            public override string ToString()
            {
                return "����ϰ�����";
            }
        }
    }
}
