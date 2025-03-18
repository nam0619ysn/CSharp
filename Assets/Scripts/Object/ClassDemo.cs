using UnityEngine;

public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClassONe.Hi();
        ClassTwo.Hi();


        ClassTwo two = new ClassTwo();
        two.Hello();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
