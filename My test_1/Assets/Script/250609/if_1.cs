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

        Debug.Log($"������ : {random}�Դϴ�.");

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
            Debug.Log("������");
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
        chas.Add("SR : ���");
        chas.Add("SR : ����");
        chas.Add("SR : ��ũ");
        chas.Add("SR : �׸�");
        chas.Add("SSR : ����");

        //int random = Random.Range(1, 6);

        //Debug.Log($"������ : {random}�Դϴ�.");

        for(int i = 1; i < 11; i++)
        {
            int random = Random.Range(0, chas.Count);
            Debug.Log(i + "��° ���� - " + chas[random]);
        }


    }

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }
}
