using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total_cal_Network : MonoBehaviour {

    // 네트워크 결과창에서만 작동하는 스크립트

    public Text MyMAXCOMBO;
    public Text MyBOOST;
    public Text MyScore;

    public Text EnemyMAXCOMBO;
    public Text EnemyBOOST;
    public Text EnemyScore;

    public int selectindex;
    public bool IsHard = false;

    public Text Songname;
    public Text Level;

    public GameObject COMBO_WIN_LOSE;
    public GameObject BOOST_WIN_LOSE;
    public GameObject SCORE_WIN_LOSE;
    public GameObject TOTAL_WIN_LOSE;

    public bool Combo_Win;
    public bool Boost_Win;
    public bool Score_Win;

    Color32 WIN = new Color32(0x35, 0xAB, 0xFF, 0x80);
    Color32 LOSE = new Color32(0xB2, 0x08, 0x0B, 0x80);

    int My_WinCount;
    int Enemy_Wincount;
    bool One = true;
    bool Two = true;
    bool Three = true;
    void Awake()
    {
        MyMAXCOMBO.text = Combo.max_combo.ToString();
        MyBOOST.text = Combo.BoostX.ToString();
        MyScore.text = Combo.score.ToString();

        EnemyMAXCOMBO.text = Ingame_Network.Enemy_Combo_Value.ToString();
        EnemyBOOST.text = Ingame_Network.Enemy_Boost_Value.ToString();
        EnemyScore.text = Ingame_Network.Enemy_Score_Value.ToString();

        selectindex = Selector.selectindex;
        IsHard = Selector.IsSelectHard;

        // 적 수치도 가져오기
    }


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        if (int.Parse(MyMAXCOMBO.text) == int.Parse(EnemyMAXCOMBO.text))
        {
            // Draw
        }
        else if (int.Parse(MyMAXCOMBO.text) < int.Parse(EnemyMAXCOMBO.text))
        {
            Combo_Win = false;
        }
        else
        {
            Combo_Win = true;
        }

        if (int.Parse(MyBOOST.text) == int.Parse(EnemyBOOST.text))
        {
            // Draw
        }
        else if (int.Parse(MyBOOST.text) < int.Parse(EnemyBOOST.text))
        {
            Boost_Win = false;
        }
        else
        {
            Boost_Win = true;
        }

        if (int.Parse(MyScore.text) == int.Parse(EnemyScore.text))
        {
            // Draw
        }
        else if (int.Parse(MyScore.text) < int.Parse(EnemyScore.text))
        {
            Score_Win = false;
        }
        else
        {
            Score_Win = true;
        }

        if (Combo_Win && One)
        {
            My_WinCount++;
            One = false;
        }
        else
        {
            Enemy_Wincount++;
            One = false;
        }

        if (Boost_Win && Two)
        {
            My_WinCount++;
            Two = false;
        }
        else
        {
            Enemy_Wincount++;
            Two = false;
        }


        if (Score_Win && Three)
        {
            My_WinCount++;
            Three = false;
        }
        else
        {
            Enemy_Wincount++;
            Three = false;
        }

        if(My_WinCount > 1)
        {
           TOTAL_WIN_LOSE.GetComponent<Text>().text = "WIN";
           TOTAL_WIN_LOSE.GetComponent<Outline>().effectColor = WIN;
        }
        else
        {
            TOTAL_WIN_LOSE.GetComponent<Text>().text = "LOSE";
            TOTAL_WIN_LOSE.GetComponent<Outline>().effectColor = LOSE;
        }


        if(Score_Win)
        {
            SCORE_WIN_LOSE.GetComponent<Text>().text = "WIN";
            SCORE_WIN_LOSE.GetComponent<Outline>().effectColor = WIN;
        }
        else
        {
            SCORE_WIN_LOSE.GetComponent<Text>().text = "LOSE";
            SCORE_WIN_LOSE.GetComponent<Outline>().effectColor = LOSE;
        }

        if(Boost_Win)
        {
            BOOST_WIN_LOSE.GetComponent<Text>().text = "WIN";
            BOOST_WIN_LOSE.GetComponent<Outline>().effectColor = WIN;
        }
        else
        {
            BOOST_WIN_LOSE.GetComponent<Text>().text = "LOSE";
            BOOST_WIN_LOSE.GetComponent<Outline>().effectColor = LOSE;
        }

        if(Combo_Win)
        {
            COMBO_WIN_LOSE.GetComponent<Text>().text = "WIN";
            COMBO_WIN_LOSE.GetComponent<Outline>().effectColor = WIN;
        }
        else
        {
            COMBO_WIN_LOSE.GetComponent<Text>().text = "LOSE";
            COMBO_WIN_LOSE.GetComponent<Outline>().effectColor = LOSE;
        }


        if (selectindex == 1)
        {
            Songname.text = "Deborah";
        }
        else if (selectindex == 2)
        {
            Songname.text = "Frozen Eyes";
        }
        else if (selectindex == 3)
        {
            Songname.text = "Houseplan";
        }
        else if (selectindex == 4)
        {
            Songname.text = "R.F.C";
        }
        else if (selectindex == 5)
        {
            Songname.text = "天地開闢";
        }
        else if (selectindex == 6)
        {
            Songname.text = "Enter the Universe";
        }
        else if (selectindex == 7)
        {
            Songname.text = "U.A.D";
        }
        else if (selectindex == 8)
        {
            Songname.text = "Lightfall";
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
    }

   /* public void Total_Reset()
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
    }*/
}
