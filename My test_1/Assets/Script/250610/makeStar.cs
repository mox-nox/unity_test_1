using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeStar : MonoBehaviour
{
    // Start is called before the first frame update
    string star;
    // 1. string.Empty
    // string ������ ���� �ʱ�ȭ �մϴ�.
    //string star;
    //star = string.Empty;

    // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    //star += "��"; // ��
    //star += "��"; // ��ĭ
    //star += "\n"; // �ٹٲ�

    // 3. Debug.Log("");
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    //Debug.Log(star);


    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                if(i >= j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2
        for (int i = 0;i < 5;i++)
        {
            for (int j = 0;j < 5;j++)
            {
                if(i <= j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        for( int i = 0; i < 5; i++)
        {
            for( int j = 0; j < 5; j++)
            {
                if (i >= j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }
        for( int i = 1; i < 5; i++)
        {
            for(int j = 4; j >= 0; j--)
            {
                if(i<=j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4
        for(int i = 0;i < 5; i++)
        {
            for(int j = 4;j >= 0; j--)
            {
                if (i >= j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }
        for(int i = 0;i < 4; i++)
        {
            for(int j=0; j < 5; j++)
            {
                if(i<j)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        int j = 0;
        int jMax = 9;
        int iMax = 5;
        int n = 0;

        // ������ 5
        for( int i = iMax-1; i >= 0; i--)
        {
            while(j < jMax)
            {
                if (i != j)
                {
                    star += "��";
                    j++;
                }
                else
                {
                    star += "��";
                    n = jMax - j-1;
                    for(int k = 0; k < n-j; k++)
                    {
                        star += "��";
                    }
                    j = n+1;
                }
            }
            star += "\n";
            j = 0;
        }
        for(int i = 1; i < iMax; i++)
        {
            while(j < jMax)
            {
                if (i != j)
                {
                    star += "��";
                    j++;
                }
                else
                {
                    star += "��";
                    n = jMax - j-1;
                    for (int k = 0; k < n - j; k++)
                    {
                        star += "��";
                    }
                    j = n + 1;
                }
            }
            star += "\n";
            j = 0;
        }
        Debug.Log(star);
    }

    void Star5_ex()
    {
        star = "";
        for (int i = 1; i < 10; i++)
        {
            addSpace(Mathf.Abs(i - 5));
            addStar(9 - Mathf.Abs(i - 5) * 2);
            star += "\n";
        }
        Debug.Log(star);
    }
    void addStar(int iteration)
    {
        for (int i = 0; i < iteration; i++)
        {
            star += "��";
        }
    }
    void addSpace(int iteration)
    {
        for (int i = 0; i < iteration; i++)
        {
            star += "��";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
