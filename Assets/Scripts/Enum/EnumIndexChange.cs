using UnityEngine;
enum Animale
{
    Horse,
    Sheep=5,
    Monkey
}
public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
