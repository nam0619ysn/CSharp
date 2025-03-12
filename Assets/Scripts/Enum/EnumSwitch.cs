using UnityEngine;

public class EnumSwich : MonoBehaviour
{
    enum Animalw
    {
        Chicken,
        Dog,
        Pig
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);
    }

    // Update is called once per frame
    void PrintAnimal(Animalw animal)
    {
        switch (animal)
        {
            case Animalw.Chicken:
                Debug.Log("´ß");
                break;
            case Animalw.Dog:
                Debug.Log("°³");
                break;
            case Animalw.Pig:
                Debug.Log("µÅÁö");
                break;
            
        }
    }
}
