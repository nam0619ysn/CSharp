using UnityEngine;

public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        int i = 1;
        do
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
            

            i++;
        }
        while (i <= n);
        Debug.Log($"1~{n}±îÁö È¦¼öÇÕ:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
