using UnityEngine;

public class EnumAnimals : MonoBehaviour
{

    enum Animal
    {
        Mouse,
        Cow,
        Tiger,
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        if(animal == Animal.Tiger)
        {
            Debug.Log("È£¶ûÀÌ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
