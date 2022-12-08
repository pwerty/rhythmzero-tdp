using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Font_Admin : MonoBehaviour
{
    // 폰트 계열 아이템 관리 스크립트
    // 폰트 계열 아이템은 11월 28일 기준 3가지가 있다.
    // 1. COMBO FONT
    // 2. BOOST FONT
    // 3. JUDGE FONT
    public Text ComboFont1;
    public Text ComboFont2;
    public Text ComboFont3;
    public Text ComboFont4;
    public Text ComboFont5;
    public Text ComboFont6;
    public Text ComboFont7;
    public Text ComboFont8;
    public Text ComboFont9;
    public Text ComboFont10;

    public Text BoostFont1;
    public Text BoostFont2;
    public Text BoostFont3;
    public Text BoostFont4;
    public Text BoostFont5;
    public Text BoostFont6;
    public Text BoostFont7;
    public Text BoostFont8;
    public Text BoostFont9;
    public Text BoostFont10;

    static public int ComboFont_Switch;
    static public int BoostFont_Switch;
    static public int JudgeFont_Switch;




    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.HasKey("ComboFont_Switch"))
        {
            ComboFont_Switch = PlayerPrefs.GetInt("ComboFont_Switch");
        }
        else
        {
            PlayerPrefs.SetInt("ComboFont_Switch", 1);
            ComboFont_Switch = PlayerPrefs.GetInt("ComboFont_Switch");
        }

        if (PlayerPrefs.HasKey("BoostFont_Switch"))
        {
            BoostFont_Switch = PlayerPrefs.GetInt("ComboFont_Switch");
        }
        else
        {
            PlayerPrefs.SetInt("BoostFont_Switch", 1);
            BoostFont_Switch = PlayerPrefs.GetInt("ComboFont_Switch");

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ComboFont_Switch == 1)
        {
            ComboFont1.text = "착용중";
        }
        else
        {
            ComboFont1.text = "-";
        }

        if (ComboFont_Switch == 2)
        {
            ComboFont2.text = "착용중";
        }
        else
        {
            ComboFont2.text = "-";
        }

        if (ComboFont_Switch == 3)
        {
            ComboFont3.text = "착용중";
        }
        else
        {
            ComboFont3.text = "-";
        }
        
        if (ComboFont_Switch == 4)
        {
            ComboFont4.text = "착용중";
        }
        else
        {
            ComboFont4.text = "-";
        }

        if (ComboFont_Switch == 5)
        {
            ComboFont5.text = "착용중";
        }
        else
        {
            ComboFont5.text = "-";
        }

        if (ComboFont_Switch == 6)
        {
            ComboFont6.text = "착용중";
        }
        else
        {
            ComboFont6.text = "-";
        }

        if (ComboFont_Switch == 7)
        {
            ComboFont7.text = "착용중";
        }
        else
        {
            ComboFont7.text = "-";
        }

        if (ComboFont_Switch == 8)
        {
            ComboFont8.text = "착용중";
        }
        else
        {
            ComboFont8.text = "-";
        }

        if (ComboFont_Switch == 9)
        {
            ComboFont9.text = "착용중";
        }
        else
        {
            ComboFont9.text = "-";
        }

        if (ComboFont_Switch == 10)
        {
            ComboFont10.text = "착용중";
        }
        else
        {
            ComboFont10.text = "-";
        }
        

        if (BoostFont_Switch == 1)
        {
            BoostFont1.text = "착용중";
        }
        else
        {
            BoostFont1.text = "-";
        }

        if (BoostFont_Switch == 2)
        {
            BoostFont2.text = "착용중";
        }
        else
        {
            BoostFont2.text = "-";
        }

        if (BoostFont_Switch == 3)
        {
            BoostFont3.text = "착용중";
        }
        else
        {
            BoostFont3.text = "-";
        }

        if (BoostFont_Switch == 4)
        {
            BoostFont4.text = "착용중";
        }
        else
        {
            BoostFont4.text = "-";
        }

        if (BoostFont_Switch == 5)
        {
            BoostFont5.text = "착용중";
        }
        else
        {
            BoostFont5.text = "-";
        }

        if (BoostFont_Switch == 6)
        {
            BoostFont6.text = "착용중";
        }
        else
        {
            BoostFont6.text = "-";
        }

        if (BoostFont_Switch == 7)
        {
            BoostFont7.text = "착용중";
        }
        else
        {
            BoostFont7.text = "-";
        }

        if (BoostFont_Switch == 8)
        {
            BoostFont8.text = "착용중";
        }
        else
        {
            BoostFont8.text = "-";
        }

        if (BoostFont_Switch == 9)
        {
            BoostFont9.text = "착용중";
        }
        else
        {
            BoostFont9.text = "-";
        }

        if (BoostFont_Switch == 10)
        {
            BoostFont10.text = "착용중";
        }
        else
        {
            BoostFont10.text = "-";
        }

    }

    public void SwitchToComboFont1()
    {
        ComboFont_Switch = 1;
        PlayerPrefs.SetInt("ComboFont_Switch", 1);
    }

    public void SwitchToComboFont2()
    {
        ComboFont_Switch = 2;
        PlayerPrefs.SetInt("ComboFont_Switch", 2);
    }

    public void SwitchToComboFont3()
    {
        ComboFont_Switch = 3;
        PlayerPrefs.SetInt("ComboFont_Switch", 3);
    }

    public void SwitchToComboFont4()
    {
        ComboFont_Switch = 4;
        PlayerPrefs.SetInt("ComboFont_Switch", 4);
    }

    public void SwitchToComboFont5()
    {
        ComboFont_Switch = 5;
        PlayerPrefs.SetInt("ComboFont_Switch", 5);
    }

    public void SwitchToComboFont6()
    {
        ComboFont_Switch = 6;
        PlayerPrefs.SetInt("ComboFont_Switch", 6);
    }

    public void SwitchToComboFont7()
    {
        ComboFont_Switch = 7;
        PlayerPrefs.SetInt("ComboFont_Switch", 7);
    }

    public void SwitchToComboFont8()
    {
        ComboFont_Switch = 8;
        PlayerPrefs.SetInt("ComboFont_Switch", 8);
    }

    public void SwitchToComboFont9()
    {
        ComboFont_Switch = 9;
        PlayerPrefs.SetInt("ComboFont_Switch", 9);
    }

    public void SwitchToComboFont10()
    {
        ComboFont_Switch = 10;
        PlayerPrefs.SetInt("ComboFont_Switch", 10);
    }



    public void SwitchToBoostFont1()
    {
        BoostFont_Switch = 1;
        PlayerPrefs.SetInt("BoostFont_Switch", 1);
    }

    public void SwitchToBoostFont2()
    {
        BoostFont_Switch = 2;
        PlayerPrefs.SetInt("BoostFont_Switch", 2);
    }

    public void SwitchToBoostFont3()
    {
        BoostFont_Switch = 3;
        PlayerPrefs.SetInt("BoostFont_Switch", 3);
    }

    public void SwitchToBoostFont4()
    {
        BoostFont_Switch = 4;
        PlayerPrefs.SetInt("BoostFont_Switch", 4);
    }

    public void SwitchToBoostFont5()
    {
        BoostFont_Switch = 5;
        PlayerPrefs.SetInt("BoostFont_Switch", 5);
    }

    public void SwitchToBoostFont6()
    {
        BoostFont_Switch = 6;
        PlayerPrefs.SetInt("BoostFont_Switch", 6);
    }

    public void SwitchToBoostFont7()
    {
        BoostFont_Switch = 7;
        PlayerPrefs.SetInt("BoostFont_Switch", 7);
    }

    public void SwitchToBoostFont8()
    {
        BoostFont_Switch = 8;
        PlayerPrefs.SetInt("BoostFont_Switch", 8);
    }

    public void SwitchToBoostFont9()
    {
        BoostFont_Switch = 9;
        PlayerPrefs.SetInt("BoostFont_Switch", 9);
    }

    public void SwitchToBoostFont10()
    {
        BoostFont_Switch = 10;
        PlayerPrefs.SetInt("BoostFont_Switch", 10);
    }
}

