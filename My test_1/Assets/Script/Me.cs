using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour
{
    private string lastName = "조";
    private string firstName = "성재";
    private int age = 28;
    private double height = 174.3;
    private string adress = "경기도";
    private double weight = 73.4;
    private int score = 90;
    private string gender = "남자";
    private string mbti = "intp";
    private int earphoneNum = 10;

    void Start()
    {
        selfName();
        selfAge();
        selfGender();
        selfHeight();
        selfWeight();
        selfScore();
        selfAdress();
        selfMbti();
        selfEarphone();

    }
    public void selfName()
    {
        Debug.Log("제 이름은 " + lastName + firstName + "입니다.");
    }
    public void selfAge()
    {
        Debug.Log("제 나이는 " + age + "입니다.");
    }
    public void selfScore()
    {
        Debug.Log("제 점수는 " + score + "점 입니다.");
    }
    public void selfGender()
    {
        Debug.Log("제 성별은 " + gender + "입니다.");
    }
    public void selfHeight()
    {
        Debug.Log("제 키는 " + height + "cm 입니다.");
    }
    public void selfWeight()
    {
        Debug.Log("제 몸무게는 " + weight + "입니다.");
    }
    public void selfMbti()
    {
        Debug.Log("제 mbti는 " + mbti + "입니다.");
    }
    public void selfEarphone()
    {
        Debug.Log("제 이어폰 갯수는 " + earphoneNum + "개 입니다.");
    }
    public void selfAdress()
    {
        Debug.Log("제 주소는 " + adress + "입니다.");
    }

}
