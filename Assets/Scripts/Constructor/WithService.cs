using UnityEngine;
namespace Constructor
{
    public class WithService 
    {
        private readonly string serviceName;

        public WithService()
        {
            serviceName = "����";
        }

       public WithService(string _name)
        {
            serviceName = _name;
        }

        public void Run()
        {
            //serviceName = "File";
            Debug.Log($"{serviceName}�� ����");
        }

    }
}
