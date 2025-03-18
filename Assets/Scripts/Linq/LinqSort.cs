using System.Linq;
using UnityEngine;
using System.Collections.Generic;
public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] colors = { "Red", "Green", "Blue" };

        colors.OrderBy(s => s);

        IEnumerable<string> sortedColors = colors.OrderBy(s => s);

        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }

        IEnumerable<string> sortedColors2 = colors.OrderByDescending(s => s);


        foreach (var color in sortedColors2)
        {
            Debug.Log(color);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
