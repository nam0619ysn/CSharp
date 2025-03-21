using UnityEngine;
namespace Inheritence11
{
    public class BaseClass
    {
        private string word;

       protected string Word
        {
            get { return word; }
            set { word = value; }
        }
    }
    public class SubCalss : BaseClass
    {
        //public void Succubrf;
    }


}