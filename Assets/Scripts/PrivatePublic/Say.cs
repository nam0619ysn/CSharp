using UnityEngine;
namespace PrivatePublic 
{


    public class Say : MonoBehaviour
    {

        string message = "�ȳ��ϼ���";

        public void Hi() 
        {
            this.message = "�ݰ����ϴ�";
            Debug.Log(this.message);
        }


    }



}

