using Unity.Mathematics;
using UnityEngine;

//struct Point
//   {
         
//    public int x;
//    public int y;
//    }
public class StructDescription : MonoBehaviour
{
    struct Point
    {

        public int x;
        public int y;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Point p;
        p.x = 100;
        p.y = 200;
        Debug.Log($"x:{p.x},y:{p.y}");
    }

    // Update is called once per frame
    
}
