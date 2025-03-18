using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class LinlkWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        //IEnumerable<int> numNumbers = numbers.Where(n => n > 3);
        List<int> numNumbers = numbers.Where(n => n > 3 && n% 2 == 0).ToList();

        foreach (var n in numNumbers)
        {
            Debug.Log(n);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
