using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3)&&(j != 3);
        Debug.Log("r:" + r);

        r = (i != 3) || (j == 3);
        Debug.Log("r:" + r);
        r = (i >=5);
        Debug.Log("!r:" + !r);

       
        Debug.Log((1==1)||(1!=1));

        bool bln1 = true;
        bool bln2 = false;

        Debug.Log(bln1 && bln2);
        Debug.Log(bln1 || bln2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
