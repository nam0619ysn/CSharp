using UnityEngine;



enum Animals
{
    Rabbit,
    Dragon,
    Snake,
}

public class EnumIndex : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon{num},{str}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
