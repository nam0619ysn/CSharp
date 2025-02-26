//[1]네임스페이스 선언부
using UnityEngine;//현제(FileNew)클래스 파일에서 UnityEngine 네임스페이스

//[2] 클래스 선언부: 클래스의 이름은 FileNew
public class FileNew : MonoBehaviour
{
    //[3](start)메서드 선언: 프로그램 시작시 1번
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[5]명령문
         Debug.Log("Hello World");
    }
    //[4](Update)메서드선언
    // Update is called once per frame
    void Update()
    {
       
    }
}
