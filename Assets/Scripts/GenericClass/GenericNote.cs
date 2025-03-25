using UnityEngine;
namespace GenericClass
{
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup cup = new Cup();

            Cup<string> text = new Cup<string>();
            text.Content = "문자열";
            //text.Content = 1234;

            Cup<int> number = new Cup<int>();
            //number.Content = "문자열";
            number.Content = 1234;

            Debug.Log($"{text.Content}-{number.Content}");

            Cup<Water> water = new Cup<Water>();
            water.Content = new Water();
            Debug.Log(water.Content.ToString());

            Cup<Coffe> coffe = new Cup<Coffe>();
            coffe.Content = new Coffe();
            Debug.Log(coffe.Content.ToString());
        }

    }
}