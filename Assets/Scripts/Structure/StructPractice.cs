using UnityEngine;

struct Score
{
    public int kor;
    public int eng;
}

struct Student
{
    public int number;
    public string name;
    public Score scores;
}

public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Student[] students = new Student[3];

        students[0].number = 1;
        students[0].name = "홍길동";
        students[0].scores.kor = 100;
        students[0].scores.eng = 90;

        students[1].number = 2;
        students[1].name = "백두산";
        students[1].scores.kor = 90;
        students[1].scores.eng = 80;

        students[2].number = 3;
        students[2].name = "임꺽정";
        students[2].scores.kor = 90;
        students[2].scores.eng = 75;

        for (int i=0; i< students.Length; i++)
        {
            Debug.Log($"{students[i].number}-{students[i].name}:국어:{students[i].scores.kor} 영여:{students[i].scores.eng}");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
