using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour
{
    private string lastName = "��";
    private string firstName = "����";
    private int age = 28;
    private double height = 174.3;
    private string adress = "��⵵";
    private double weight = 73.4;
    private int score = 90;
    private string gender = "����";
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
        Debug.Log("�� �̸��� " + lastName + firstName + "�Դϴ�.");
    }
    public void selfAge()
    {
        Debug.Log("�� ���̴� " + age + "�Դϴ�.");
    }
    public void selfScore()
    {
        Debug.Log("�� ������ " + score + "�� �Դϴ�.");
    }
    public void selfGender()
    {
        Debug.Log("�� ������ " + gender + "�Դϴ�.");
    }
    public void selfHeight()
    {
        Debug.Log("�� Ű�� " + height + "cm �Դϴ�.");
    }
    public void selfWeight()
    {
        Debug.Log("�� �����Դ� " + weight + "�Դϴ�.");
    }
    public void selfMbti()
    {
        Debug.Log("�� mbti�� " + mbti + "�Դϴ�.");
    }
    public void selfEarphone()
    {
        Debug.Log("�� �̾��� ������ " + earphoneNum + "�� �Դϴ�.");
    }
    public void selfAdress()
    {
        Debug.Log("�� �ּҴ� " + adress + "�Դϴ�.");
    }

}
