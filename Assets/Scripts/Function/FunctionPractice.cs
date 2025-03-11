using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result =Substract(5,3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Divide(5, 3);
        Debug.Log(result); 
        result = Remainder(5, 3);
        Debug.Log(result);

        
    }

    // Update is called once per frame
    int Add(int x,int y)
    {
        return x + y;
    }
    //화살표,람다식,축약형 함수
    int Substract(int x, int y)=>x-y;
    int Minus(int x, int y)
    {
        return x - y;
    }
    int Multiply(int x, int y) => x * y;
   
    int Divide(int x, int y)=> x / y;
    
    int Remainder(int x, int y)=>x % y;
    
         
    
}

