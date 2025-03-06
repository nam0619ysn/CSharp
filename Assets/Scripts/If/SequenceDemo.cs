using UnityEngine;
using UnityEngine.Rendering;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;
        double avg = 0.0;

        total = kor + eng;
        avg = total / 2.0;

        Debug.Log($"ÃÑÁ¡:{total}");
        Debug.Log($"Æò±Õ:{avg}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
