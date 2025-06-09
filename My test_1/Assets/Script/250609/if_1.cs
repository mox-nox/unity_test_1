using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class if_1 : MonoBehaviour
{
    int count;

    private void Awake()
    {
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        /*
        int random = Random.Range(1, 101);

        Debug.Log($"랜덤값 : {random}입니다.");

        if (random <= 10)
        {
            Debug.Log("10%");
        }
        else if (random <= 30)
        {
            Debug.Log("20%");
        }
        else
        {
            Debug.Log("나머지");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gacha()
    {
        List<string> chas = new List<string>();
        chas.Add("SR : 블루");
        chas.Add("SR : 엘로");
        chas.Add("SR : 핑크");
        chas.Add("SR : 그린");
        chas.Add("SSR : 레드");

        //int random = Random.Range(1, 6);

        //Debug.Log($"랜덤값 : {random}입니다.");

        for(int i = 1; i < 11; i++)
        {
            int random = Random.Range(0, chas.Count);
            Debug.Log(i + "번째 가차 - " + chas[random]);
        }


    }

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
                        // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }
}
