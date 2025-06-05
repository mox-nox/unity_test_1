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
        //Debug.Log("최초 한번 실행");
    }

    void OnEnable()
    {
        //Debug.Log(Random.Range(1, 100));
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
        //Debug.Log($"나의 레벨은 {playerLevel}입니다.");
        //Debug.Log("한번만 실행");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("여러번 실행");
    }
}

