using System.Linq;
using UnityEngine;

public class LinqMinMAx : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3 };

        int max =0;
            int min = 0;

        max = numbers.Max();
        min = numbers.Min();

        Debug.Log($"최대:{max}최소 {min}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
