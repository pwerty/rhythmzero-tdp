using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total_cal : MonoBehaviour {

   public int a_count;
   public int b_count;
   public int c_count;
   public int d_count;
   public int e_count;
   public int f_count;
   public int max_combo;
   public int boostX;
   public int Score;
    public int selectindex;
    public bool IsHard = false;

    public bool IsPlayerGet = false;

    public int PlayerMoney;
    public int PlayerExp;
    public float ratio_calc;

    static public int Will_Give_Money1_2;
    static public int Will_Give_Money1;
    static public int Will_Give_Money0_75;
    static public int Will_Give_Money0_5;
    static public int Will_Give_Money0_49;

    static public int Will_Give_Exp1_2;
    static public int Will_Give_Exp1;
    static public int Will_Give_Exp0_75;
    static public int Will_Give_Exp0_5;
    static public int Will_Give_Exp0_49;

    public GameObject TextA;
    public GameObject TextB;
    public GameObject TextC;
    public GameObject TextD;
    public GameObject TextE;
    public GameObject TextF;
    public GameObject TextMaxCombo;
    public GameObject TextBoostX;
    public GameObject TextScore;

    public Text Will_Give_Money_Text;
    public Text Will_Give_Exp_Text;
    public Text Songname;
    public Text Level;

    public GameObject AllCombo;

    // Use this for initialization
    void Start () {

        a_count = Combo.a_count;
        b_count = Combo.b_count;
        c_count = Combo.c_count;
        d_count = Combo.d_count;
        e_count = Combo.e_count;
        f_count = Combo.f_count;
        max_combo = Combo.max_combo;
        boostX = Combo.BoostX;
        Score = Combo.score;
        selectindex = Selector.selectindex;
        IsHard = Selector.IsSelectHard;

        PlayerMoney = PlayerPrefs.GetInt("Player_Money");
        PlayerExp = PlayerPrefs.GetInt("Player_Exp");
        ratio_calc = a_count / (float)Bms.totalNoteCount_forResult;

        if(Bms.totalNoteCount_forResult <= 200)
        {
            Will_Give_Money1_2 = 1200;
            Will_Give_Money1 = 1000;
            Will_Give_Money0_75 = 750;
            Will_Give_Money0_5 = 500;
            Will_Give_Money0_49 = 350;

            Will_Give_Exp1_2 = 120;
            Will_Give_Exp1 = 100;
            Will_Give_Exp0_75 = 75;
            Will_Give_Exp0_5 = 50;
            Will_Give_Exp0_49 = 35;
        }
        else if(Bms.totalNoteCount_forResult <= 400)
        {
            Will_Give_Money1_2 = 1500;
            Will_Give_Money1 = 1250;
            Will_Give_Money0_75 = 940;
            Will_Give_Money0_5 = 630;
            Will_Give_Money0_49 = 440;
        }
        else if(Bms.totalNoteCount_forResult <= 600)
        {
            Will_Give_Money1_2 = 1800;
            Will_Give_Money1 = 1500;
            Will_Give_Money0_75 = 1130;
            Will_Give_Money0_5 = 750;
            Will_Give_Money0_49 = 530;

        }
        else if(Bms.totalNoteCount_forResult <= 800)
        {
            Will_Give_Money1_2 = 2100;
            Will_Give_Money1 = 1750;
            Will_Give_Money0_75 = 1310;
            Will_Give_Money0_5 = 880;
            Will_Give_Money0_49 = 610;

        }
        else if(Bms.totalNoteCount_forResult <= 1000)
        {

            Will_Give_Money1_2 = 2400;
            Will_Give_Money1 = 2000;
            Will_Give_Money0_75 = 1500;
            Will_Give_Money0_5 = 1000;
            Will_Give_Money0_49 = 700;
        }
        else
        {
            Will_Give_Money1_2 = 1;
            Will_Give_Money1 = 1;
            Will_Give_Money0_75 = 1;
            Will_Give_Money0_5 = 1;
            Will_Give_Money0_49 = 1;

            Will_Give_Exp1_2 = 1;
            Will_Give_Exp1 = 1;
            Will_Give_Exp0_75 = 1;
            Will_Give_Exp0_5 = 1;
            Will_Give_Exp0_49 = 1;
        }

        Will_Give_Exp1_2 = Will_Give_Money1_2 / 10;
        Will_Give_Exp1 = Will_Give_Money1 / 10;
        Will_Give_Exp0_75 = Will_Give_Money0_75 / 10;
        Will_Give_Exp0_5 = Will_Give_Money0_5 / 10;
        Will_Give_Exp0_49 = Will_Give_Money0_49 / 10;

        

    }


    
	
	// Update is called once per frame
	void Update () {
        print(5 / 2);
        print(ratio_calc);
        print(a_count);
        print(Bms.totalNoteCount_forResult);
        TextA.GetComponent<TextMesh>().text = (a_count.ToString());
        TextB.GetComponent<TextMesh>().text = (b_count.ToString());
        TextC.GetComponent<TextMesh>().text = (c_count.ToString());
        TextD.GetComponent<TextMesh>().text = (d_count.ToString());
        TextE.GetComponent<TextMesh>().text = (e_count.ToString());
        TextF.GetComponent<TextMesh>().text = (f_count.ToString());
        TextMaxCombo.GetComponent<TextMesh>().text = (max_combo.ToString());
        TextBoostX.GetComponent<TextMesh>().text = (boostX.ToString());
        TextScore.GetComponent<TextMesh>().text = (Score.ToString());

        if (selectindex == 1) //PlayerPrefs는 최고 기록을 저장하는데, 지금 NM, HD 관계 없이 저장되고 있음 -1218
        {
            Songname.text = "Deborah";
            Deborah_score();
        }
        else if (selectindex == 2)
        {
            Songname.text = "Frozen Eyes";
            Frozeneyes_score();
        }
        else if (selectindex == 3)
        {
            Songname.text = "Houseplan";
            Houseplan_score();
        }
        else if (selectindex == 4)
        {
            Songname.text = "R.F.C";
            RFC_score();
        }
        else if (selectindex == 5)
        {
            Songname.text = "天地開闢";
            Chun_gi_score();
        }
        else if (selectindex == 6)
        {
            Songname.text = "Enter the Universe";
            EntertheUniverse_score();
        }
        else if (selectindex == 7)
        {
            Songname.text = "U.A.D";
            UAD_score();
        }
        else if (selectindex == 8)
        {
            Songname.text = "Lightfall";
            Lightfall_score();
        }
        else if (selectindex == 9)
        {
            Songname.text = "God Mode";
            Lightfall_score();
        }
        else if (selectindex == 10)
        {
            Songname.text = "BEDLAM";
            Lightfall_score();
        }
        else if (selectindex == 11)
        {
            Songname.text = "Opening";
            Lightfall_score();
        }
        else
        {
            Songname.text = "플레이로 들어온 Song이 아님";
        }
        if (IsHard == true)
        {
           Level.text = "HD";
        }
        else
        {
            Level.text = "NM";
        }
        // 노트 총합 갯수가 A+B+C+D+E 와 같으면 ALL COMBO 이벤트 발생
        if (Bms.totalNoteCount_forResult == (a_count + b_count + c_count + d_count + e_count))
        {
            AllCombo.SetActive(true);
        }

        print(Bms.totalNoteCount_forResult);

        if(IsPlayerGet == false)
        {
            if (ratio_calc == 1.0f) //100%
            {
                PlayerMoney += Will_Give_Money1_2;
                PlayerExp += Will_Give_Exp1_2;
                print("100%");
                Will_Give_Money_Text.text = "+ " + Will_Give_Money1_2;
                Will_Give_Exp_Text.text = "+ " + Will_Give_Exp1_2;
            }
            else if (ratio_calc >= 0.9f) //A_count를 Float로 해야 반올림같은게 똑바로 될 것 같은데
            {
                PlayerMoney += Will_Give_Money1;
                PlayerExp += Will_Give_Exp1;
                print("better than 90%");
                Will_Give_Money_Text.text = "+ " + Will_Give_Money1;
                Will_Give_Exp_Text.text = "+ " + Will_Give_Exp1;
            }
            else if (ratio_calc >= 0.75f)
            {
                PlayerMoney += Will_Give_Money0_75;
                PlayerExp += Will_Give_Exp0_75;
                print("better than 75%");
                Will_Give_Money_Text.text = "+ " + Will_Give_Money0_75;
                Will_Give_Exp_Text.text = "+ " + Will_Give_Exp0_75;
            }
            else if (ratio_calc >= 0.5f)
            {
                PlayerMoney += Will_Give_Money0_5;
                PlayerExp += Will_Give_Exp0_5;
                print("better than 50%");
                Will_Give_Money_Text.text = "+ " + Will_Give_Money0_5;
                Will_Give_Exp_Text.text = "+ " + Will_Give_Exp0_5;
            }
            else
            {
                PlayerMoney += Will_Give_Money0_49;
                PlayerExp += Will_Give_Exp0_49;
                print("YOU SUCK");
                Will_Give_Money_Text.text = "+ " + Will_Give_Money0_49;
                Will_Give_Exp_Text.text = "+ " + Will_Give_Exp0_49;
            }
            IsPlayerGet = true;
            PlayerPrefs.SetInt("Player_Money", PlayerMoney);
            PlayerPrefs.SetInt("Player_Exp", PlayerExp);
            print("player money is : " + PlayerPrefs.GetInt("Player_Money"));
            print("player exp is : " + PlayerPrefs.GetInt("Player_Exp"));

        }
        




    }
    public void Total_Reset()
    {
        a_count = 0;
        b_count = 0;
        c_count = 0;
        d_count = 0;
        e_count = 0;
        f_count = 0;
        max_combo = 0;
        boostX = 0;
        Score = 0;
        selectindex = 0;
    }

    public void Deborah_score()
    {
        
        if(!IsHard)
        {
            if(PlayerPrefs.GetInt("deborah_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("deborah_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("deborah_NM_AllCombo", 1);
                }
            }

        }
        else
        {
            if (PlayerPrefs.GetInt("deborah_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("deborah_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("deborah_HD_AllCombo", 1);
                }
            }


        }
        print("deborah score save!");

    }

    public void Frozeneyes_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("frozeneyes_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("frozeneyes_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("frozeneyes_NM_AllCombo", 1);
                }
            }

        }
        else
        {
            if (PlayerPrefs.GetInt("frozeneyes_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("frozeneyes_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("frozeneyes_HD_AllCombo", 1);
                }
            }

        }
        print("frozen eyes score save!");
        
    }
    
    public void Houseplan_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("houseplan_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("houseplan_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("houseplan_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("houseplan_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("houseplan_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("houseplan_HD_AllCombo", 1);
                }
            }

        }
        print("houseplan score save!");
    }

    public void Chun_gi_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("chun_gi_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("chun_gi_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("chun_gi_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("chun_gi_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("chun_gi_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("chun_gi_HD_AllCombo", 1);
                }
            }

        }
        print("chun_gi score save!");
    }

    public void RFC_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("rfc_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("rfc_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("rfc_NM_AllCombo", 1);
                }
            }

        }
        else
        {
            if (PlayerPrefs.GetInt("rfc_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("rfc_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("rfc_HD_AllCombo", 1);
                }
            }


        }
        print("rfc score save!");
    }

    public void EntertheUniverse_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("entertheuniverse_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("entertheuniverse_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("entertheuniverse_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("entertheuniverse_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("entertheuniverse_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("entertheuniverse_HD_AllCombo", 1);
                }
            }


        }
        print("enter the universe score save!");
    }

    public void UAD_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("UAD_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("UAD_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("UAD_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("UAD_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("UAD_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("UAD_HD_AllCombo", 1);
                }
            }

        }

        print("uad score save!");
    }

    public void Lightfall_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("Lightfall_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("LightFall_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("LightFall_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("Lightfall_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("LightFall_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("LightFall_HD_AllCombo", 1);
                }
            }

        }
        print("lightfall score save!");
    }

    public void godmode_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("godmode_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("godmode_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("godmode_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("godmode_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("godmode_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("godmode_HD_AllCombo", 1);
                }
            }

        }
        print("godmode_score save!");
    }

    public void bedlam_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("bedlam_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("bedlam_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("bedlam_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("bedlam_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("bedlam_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("bedlam_HD_AllCombo", 1);
                }
            }

        }
        print("bedlam score save!");
    }

    public void nice_shot_score()
    {
        if (!IsHard)
        {
            if (PlayerPrefs.GetInt("nice_shot_MAXscore_NM") < Score)
            {
                PlayerPrefs.SetInt("nice_shot_MAXscore_NM", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("nice_shot_NM_AllCombo", 1);
                }
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("nice_shot_MAXscore_HD") < Score)
            {
                PlayerPrefs.SetInt("nice_shot_MAXscore_HD", Score);
                if (AllCombo.activeSelf)
                {
                    PlayerPrefs.SetInt("nice_shot_HD_AllCombo", 1);
                }
            }

        }
        print("nice_shot score save!");
    }
}
