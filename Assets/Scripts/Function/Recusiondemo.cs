using UnityEngine;

public class Recusiondemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(4 * 3 * 2 * 1);

        Debug.Log(FactorialFor(4));
        Debug.Log(Factorial(4));
        Debug.Log(Factor(4));
    }


    int Factor(int n)
    {
        //if (n <= 1)
        //    return 1;
        //return n * Factor(n - 1);

        return (n>1) ? n * Factor(n - 1) : 1;
    }

    int FactorialFor(int n)
    {
        int result = 1;

        for(int i=1;i<=n; i++)
        {
            result = result * i;
        }
        return result;
    }

    int Factorial(int n)
    {
        if(n==1)
        {
            return 1;
        }
        return n*Factorial(n-1);
    }
    // Update is called once per frame
    //void Hi()
    //{
    //    Hi();
    //}
}
