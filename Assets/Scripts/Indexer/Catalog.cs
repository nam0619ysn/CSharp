using UnityEngine;
namespace Indexer
{
    public class Catalog : MonoBehaviour
    {
      public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}�� ¦��": $"{index}�� Ȧ��";
            }
        }
    }
}