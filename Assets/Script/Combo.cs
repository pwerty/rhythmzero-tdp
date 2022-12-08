using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Combo : MonoBehaviour {
    int count;

    public int ComboSkin;

   static public int score;
    public GameObject Score;
    public GameObject Boost;
    public GameObject Health;
    public GameObject Fail_Effect;

    public Font Font1;
    public Font Font2;
    public Font Font3;
    public Font Font4;
    public Font Font5;
    public Font Font6;
    public Font Font7;
    public Font Font8;
    public Font Font9;
    public Font Font10;

    int a_score = 100;
    int b_score = 85;
    int c_score = 50;
    int d_score = 25;
    int e_score = 10;

    static public int BoostX;
   static public int a_count;
   static public int b_count;
   static public int c_count;
   static public int d_count;
   static public int e_count;
   static public int f_count;
   static public int max_combo;

    
    static public bool IsMissionPlaying = false;

    public GameObject MissionPanel;

    public Text A_count;
    //public Text B_count;

    public Text Boost_count;
    public Text Fail_count;
    public Text MaxCombo_Count;

    public GameObject MaxCombo_Count_Gear;

    // Use this for initialization
    private void Awake()
    {
        
        BoostX = 0;
        a_count = 0;
        b_count = 0;
        c_count = 0;
        d_count = 0;
        e_count = 0;
        f_count = 0;
        max_combo = 0;
        score = 0;
    }

    void Start () {
        ComboSkin = PlayerPrefs.GetInt("ComboFont_Switch");

        if (SceneManager.GetActiveScene().name == "RZ_tutorial")
        {
            ComboSkin = 1;
        }


        if (ComboSkin == 1)
        {
            GetComponent<Text>().font = Font1;
        }
        else if (ComboSkin == 2)
        {
            GetComponent<Text>().font = Font2;
        }
        else if (ComboSkin == 3)
        {
            GetComponent<Text>().font = Font3;
        }
        else if (ComboSkin == 4)
        {
            GetComponent<Text>().font = Font4;
        }
        else if (ComboSkin == 5)
        {
            GetComponent<Text>().font = Font5;
        }
        else if (ComboSkin == 6)
        {
            GetComponent<Text>().font = Font6;
        }
        else if (ComboSkin == 7)
        {
            GetComponent<Text>().font = Font7;
        }
        else if (ComboSkin == 8)
        {
            GetComponent<Text>().font = Font8;
        }
        else if (ComboSkin == 9)
        {
            GetComponent<Text>().font = Font9;
        }
        else if (ComboSkin == 10)
        {
            GetComponent<Text>().font = Font10;
        }

    }   
	
	// Update is called once per frame
	void Update () {

        if (IsMissionPlaying)
        {
            MissionPanel.SetActive(true);
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "RZ_tutorial")
            {

            }
            else
            {
                MissionPanel.SetActive(false);
            }
     
        }


        if(MissionPanel.activeSelf == true)
        {
            A_count.text = a_count.ToString();
            Boost_count.text = BoostX.ToString();
            Fail_count.text = f_count.ToString();
            MaxCombo_Count.text = max_combo.ToString();
        }
    }
    public void COMBO()
    {
        count++;
        GetComponent<Outline>().effectColor = new Color32(0x48, 0x00, 0xFF, 0x80);
        GetComponent<Text>().text = "C O M B O\n" +  count.ToString();
        this.GetComponent<Animation>().Rewind("Text_Test_Combo");
        this.GetComponent<Animation>().Play("Text_Test_Combo");
        if (max_combo < count)
        {
            max_combo = count;
            MaxCombo_Count_Gear.GetComponent<TextMesh>().text = max_combo.ToString();
            Ingame_Network.EnemyCombo();
        }


    }
    public void F_COMBO()
    {
        count = 0;
        GetComponent<Text>().text = "C O M B O \nM I S S";
        GetComponent<Outline>().effectColor = new Color32(0xFF, 0x00, 0x00, 0x80);
        this.GetComponent<Animation>().Rewind("Text_Test_Combo");
        this.GetComponent<Animation>().Play("Text_Test_Combo");
        f_count++;
        Health.GetComponent<Slider>().value -= 0.01f;
        Fail_Effect.GetComponent<Animation>().Rewind("Text_Fail_Do");
        Fail_Effect.GetComponent<Animation>().Play("Text_Fail_Do");
        Falling_From.VolumeDOWN();
    }
    // 멀티플레이 임시 테스트로 score에 Boost와 Combo당 추가 점수가 잠시 삭제됩니다.
    public void JudgeA_Score()
    {
        BoostX = Boost.GetComponent<Boost>().Boost_value;
       // score = score + (count + a_score) * BoostX;
        score = score + a_score;
        Score.GetComponent<TextMesh>().text = (score.ToString());
        a_count++;
        Health.GetComponent<Slider>().value += 0.03f;
        Falling_From.VolumeUP();
        Ingame_Network.EnemyScoreA();

    }
    public void JudgeB_Score()
    {
        BoostX = Boost.GetComponent<Boost>().Boost_value;
        // score = score + (count + b_score) * BoostX;
        score = score + b_score;
        Score.GetComponent<TextMesh>().text = (score.ToString());
        b_count++;
        Health.GetComponent<Slider>().value += 0.01f;
        Falling_From.VolumeUP();
        Ingame_Network.EnemyScoreB();
    }
    public void JudgeC_Score()
    {
        BoostX = Boost.GetComponent<Boost>().Boost_value;
        //   score = score + (count + c_score) * BoostX;
        score = score + c_score;
        Score.GetComponent<TextMesh>().text = (score.ToString());
        c_count++;
        Ingame_Network.EnemyScoreC();
    }
    public void JudgeD_Score()
    {
        BoostX = Boost.GetComponent<Boost>().Boost_value;
        // score = score + (count + d_score) * BoostX;
        score = score + d_score;
        Score.GetComponent<TextMesh>().text = (score.ToString());
        d_count++;
        Ingame_Network.EnemyScoreD();

    }
    public void JudgeE_Score()
    {
        BoostX = Boost.GetComponent<Boost>().Boost_value;
        //score = score + (count + e_score) * BoostX;
        score = score + e_score;
        Score.GetComponent<TextMesh>().text = (score.ToString());
        e_count++;
        Ingame_Network.EnemyScoreE();
    }

}
