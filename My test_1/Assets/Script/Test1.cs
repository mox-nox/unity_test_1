using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

// using System.Diagnostics;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    int playerLevel = 10;

    void Awake()
    {
        //Debug.Log("���� �ѹ� ����");
    }

    void OnEnable()
    {
        //Debug.Log(Random.Range(1, 100));
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("���� ������ " + playerLevel + "�Դϴ�.");
        //Debug.Log($"���� ������ {playerLevel}�Դϴ�.");
        //Debug.Log("�ѹ��� ����");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("������ ����");
    }
}

