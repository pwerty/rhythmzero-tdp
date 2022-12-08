using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{


    // 이곳에서 어떤 곡을 고르는지 확인하게 됩니다.
    /* 
     * 1. 누르는 순간 게임씬으로 이동하니 스타트 버튼에 따로 부여
     * 2. 난이도에 대한 시스템 부여
     * 3. 
     */

   static public int selectindex = 1;
   static public bool IsSelectHard; //노말, 하드 두개만 만들거니 우선 bool을 사용, 난이도 갯수가 추가 되는경우 bool도 수정해야합니다

    public bool HaveNormalPattern;
    public bool HaveHardPattern;

    public GameObject NormalButton;
    public GameObject HardButton;
    public GameObject ErrorMessage;

    public GameObject starter;

    // 곡 자켓
    public GameObject deborah_img;
    public GameObject frozeneyes_img;
    public GameObject houseplan_img;
    public GameObject rfc_img;
    public GameObject chun_gi_img;
    public GameObject EntertheUniverse_img;
    public GameObject UAD_img;
    public GameObject Lightfall_img;
    public GameObject GodMode_img;
    public GameObject Bedlam_img;
    public GameObject nice_shot_img;

    public GameObject deborah_button;
    public GameObject frozeneyes_button;
    public GameObject houseplan_button;
    public GameObject rfc_button;
    public GameObject chun_gi_button;
    public GameObject EntertheUniverse_button;
    public GameObject UAD_button;
    public GameObject Lightfall_button;
    public GameObject GodMode_button;
    public GameObject Bedlam_button;
    public GameObject nice_shot_button;

    public bool LevelAdded;
    public Text PatternLevel;
    public int PatternLevel_Value;
    public string LevelStars;

    public GameObject HighScore;
    public GameObject AllCombo_Img;
    public bool IsPlayerAllcombo;

    public GameObject MusicPlayer;
    public bool MusicPlayerIsPlaying;
    
    // 곡 선택 인덱스
    /* public void 곡이름키워드()
     * {
         곡 구분 번호 = N;

        노말패턴이 있습니까?
        하드패턴이 있습니까?

        오류 메시지를 비활성화합니다.
        }
        */

    public void Deborah()
    {
        selectindex = 1;
        HaveNormalPattern = true;
        HaveHardPattern = true;
 
        Another_Disable.Click();
        deborah_img.SetActive(true);
        Deborah_score();
       // HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("deborah_MAXscore_NM").ToString();


    }
    public void FrozenEyes()
    {
        selectindex = 2;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        frozeneyes_img.SetActive(true);
        Frozeneyes_score();
    }
    public void HousePlan()
    {
        selectindex = 3;

        HaveNormalPattern = true;
        HaveHardPattern = true;
        
        Another_Disable.Click();
       houseplan_img.SetActive(true);
        Houseplan_score();
    }
    public void RFC()
    {
        selectindex = 4;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
       rfc_img.SetActive(true);
        RFC_score();
    }
    public void chun_gi()
    {
        selectindex = 5;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        chun_gi_img.SetActive(true);
        Chun_gi_score();
    }
    public void EntertheUniverse()
    {
        selectindex = 6;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        EntertheUniverse_img.SetActive(true);
        EntertheUniverse_score();
    }
    public void UAD()
    {
        selectindex = 7;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        UAD_img.SetActive(true);
        UAD_score();
    }
    public void Lightfall()
    {
        selectindex = 8;

        HaveNormalPattern = true;
        HaveHardPattern = false;

        Another_Disable.Click();
        Lightfall_img.SetActive(true);
        Lightfall_score();

    }

    public void Godmode()
    {
        selectindex = 9;

        HaveNormalPattern = true;
        HaveHardPattern = false;

        Another_Disable.Click();
        GodMode_img.SetActive(true);
        Lightfall_score();

    }

    public void Bedlam()
    {
        selectindex = 10;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        Bedlam_img.SetActive(true);
        Lightfall_score();

    }


    public void nice_shot()
    {
        selectindex = 11;

        HaveNormalPattern = true;
        HaveHardPattern = true;

        Another_Disable.Click();
        nice_shot_img.SetActive(true);
        Lightfall_score();

    }

    public void Level_Normal()
    {
        IsSelectHard = false;
    }
    public void Level_Hard()
    {
        IsSelectHard = true;
    }
    //곡 선택 인덱스 문단 마감

    //Start를 누르면 아래 클래스가 작동하게 됩니다.

        /* 1. 무슨 곡인지 체크
         * 2. 난이도 체크
         */
    public void Starter()
    {
        if (selectindex == 1)
        {
            if(IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "deborah";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if(IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "deborah";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }
        if (selectindex == 2)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "frozen_eyes";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "frozen_eyes";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }
        if (selectindex == 3)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "houseplan";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "houseplan";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }
        if (selectindex == 4)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "rfc";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "rfc";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }
        if (selectindex == 5)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "chun_gi";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "chun_gi";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }
        if (selectindex == 6)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "entertheuniverse";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "entertheuniverse";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }

        if (selectindex == 7)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "UAD";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "UAD";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }

        if (selectindex == 8)
        {

            if (PlayerPrefs.GetInt("IsClear7thMission_dev") == 2) //해금조건 7번미션 클리어 상태
            {
                if (IsSelectHard == true && HaveHardPattern == true)
                {
                    NoteBar_.IsSelectHard = IsSelectHard;
                    NoteBar_.bmsName = "lightfall";
                    SceneManager.LoadScene("prev_modify_tutorial");
                }
                else if (IsSelectHard == false && HaveNormalPattern == true)
                {
                    NoteBar_.IsSelectHard = IsSelectHard;
                    NoteBar_.bmsName = "lightfall";
                    SceneManager.LoadScene("prev_modify_tutorial");
                }
                else
                {
                    ErrorMessage.SetActive(true);
                }
            }
            else
            {
                ErrorMessage.SetActive(true);
                ErrorMessage.GetComponent<Text>().text = "LightFall은 7번 미션을 클리어 하면 플레이 할 수 있습니다.";
            }
        }


        if (selectindex == 9)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "godmode";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "godmode";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }


        if (selectindex == 10)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "bedlam";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "bedlam";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }


        if (selectindex == 11)
        {
            if (IsSelectHard == true && HaveHardPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "nice_shot";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else if (IsSelectHard == false && HaveNormalPattern == true)
            {
                NoteBar_.IsSelectHard = IsSelectHard;
                NoteBar_.bmsName = "nice_shot";
                SceneManager.LoadScene("prev_modify_tutorial");
            }
            else
            {
                ErrorMessage.SetActive(true);
            }

        }

        Combo.IsMissionPlaying = false; //난 미션이 아니에요

    }

    private void Update()
    {

        if(MusicPlayer.GetComponent<AudioSource>().timeSamples > MusicPlayer.GetComponent<AudioSource>().clip.frequency * 40)
        {
            MusicPlayer.GetComponent<AudioSource>().volume = MusicPlayer.GetComponent<AudioSource>().volume - 0.02f; //매 프레임마다 -0.02씩 볼륨 내려감

            if(MusicPlayer.GetComponent<AudioSource>().volume == 0.0f)
            {
                MusicPlayer.GetComponent<AudioSource>().Stop();
            }
        }

        if(Input.GetKeyDown(KeyCode.Return) && starter.activeSelf == true)
        {
            Starter();
        }

        if (HaveNormalPattern == true)
        {
            NormalButton.SetActive(true);
        }
        else
        {
            NormalButton.SetActive(false);
        }
        
        if (HaveHardPattern == true)
        {
            HardButton.SetActive(true);
        }
        else
        {
            HardButton.SetActive(false);
        }
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(selectindex != 1)
            {
                selectindex--;
            }
            print("pressed L");

        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(selectindex != 11)
            {
                selectindex++;
            }
            print("pressed R");
        }

        if(selectindex == 1)
        {
            Deborah();
            deborah_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            deborah_button.GetComponent<Outline>().enabled = false;
        }
        if(selectindex == 2)
        {
            FrozenEyes();
            frozeneyes_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            frozeneyes_button.GetComponent<Outline>().enabled = false;
        }
        if(selectindex == 3)
        {
            HousePlan();
            houseplan_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            houseplan_button.GetComponent<Outline>().enabled = false;
        }
        if(selectindex == 4)
        {
            RFC();
            rfc_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            rfc_button.GetComponent<Outline>().enabled = false;
        }
        if (selectindex == 5)
        {
            chun_gi();
            chun_gi_button.GetComponent<Outline>().enabled = true;
            // 지금 만들고 있는것
            // 방향키에 따라서 선택곡을 이동
            // Outline False / 곡 자켓 이미지 True등 할거많다
        }
        else
        {
            chun_gi_button.GetComponent<Outline>().enabled = false;
        }
        if (selectindex == 6)
        {
            EntertheUniverse();
            EntertheUniverse_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            EntertheUniverse_button.GetComponent<Outline>().enabled = false;
        }

        if (selectindex == 7)
        {
            UAD();
            UAD_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            UAD_button.GetComponent<Outline>().enabled = false;
        }

        if (selectindex == 8)
        {
            Lightfall();
            Lightfall_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            Lightfall_button.GetComponent<Outline>().enabled = false;
        }

        if (selectindex == 9)
        {
            Godmode();
            GodMode_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            GodMode_button.GetComponent<Outline>().enabled = false;
        }

        if (selectindex == 10)
        {
            Bedlam();
            Bedlam_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            Bedlam_button.GetComponent<Outline>().enabled = false;
        }

        if (selectindex == 11)
        {
            nice_shot();
            nice_shot_button.GetComponent<Outline>().enabled = true;
        }
        else
        {
            nice_shot_button.GetComponent<Outline>().enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(NormalButton.GetComponent<Outline>().isActiveAndEnabled == false)
            {
                Level_Normal();
                NormalButton.GetComponent<Outline>().enabled = true;
                HardButton.GetComponent<Outline>().enabled = false;


                starter.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(HardButton.GetComponent<Outline>().isActiveAndEnabled == false)
            {
                // 하드버튼 선택
                Level_Hard();
                HardButton.GetComponent<Outline>().enabled = true;
                NormalButton.GetComponent<Outline>().enabled = false;
                starter.SetActive(true);

            }
        }

        if (selectindex == 1)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★";
                PatternLevel_Value = 8;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★★";
                PatternLevel_Value = 4;
            }
             
            LevelAdded = false;
        }
        else if (selectindex == 2)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★";
                PatternLevel_Value = 9;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★★";
                PatternLevel_Value = 4;
            }
             
        }
        else if (selectindex == 3)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★";
                PatternLevel_Value = 8;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★";
                PatternLevel_Value = 2;
            }
             
        }
        else if (selectindex == 4)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★";
                PatternLevel_Value = 7;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★";
                PatternLevel_Value = 3;
            }
             
        }
        else if (selectindex == 5)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★";
                PatternLevel_Value = 10;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★";
                PatternLevel_Value = 8;
            }
             
        }
        else if (selectindex == 6)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★★";
                PatternLevel_Value = 12;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★";
                PatternLevel_Value = 8;
            }
             
        }
        else if (selectindex == 7)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★★★";
                PatternLevel_Value = 13;
            }
            else
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★";
               PatternLevel_Value = 8;
            }
             
        }
        else if (selectindex == 8)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★";
                PatternLevel_Value = 11;
            }
            else
            {
                PatternLevel_Value = 15;

            }

        }
        else if (selectindex == 9)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★";
                PatternLevel_Value = 11;
            }
            else
            {
                PatternLevel_Value = 15;

            }

        }
        else if (selectindex == 10)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★";
                PatternLevel_Value = 11;
            }
            else
            {
                PatternLevel_Value = 15;

            }

        }
        else if (selectindex == 11)
        {
            if (IsSelectHard)
            {
                PatternLevel.text = "LEVEL : \n ★★★★★★★★★★★";
                PatternLevel_Value = 11;
            }
            else
            {
                PatternLevel_Value = 15;

            }

        }


    }




    public void Deborah_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("deborah_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("deborah_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("deborah_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("deborah_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }

        }
    }

    public void Frozeneyes_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("frozeneyes_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("frozeneyes_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("frozeneyes_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("frozeneyes_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }

        }
    }

    public void Houseplan_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("houseplan_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("houseplan_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }

        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("houseplan_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("houseplan_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void Chun_gi_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("chun_gi_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("chun_gi_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("chun_gi_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("chun_gi_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }

        }
    }

    public void RFC_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("rfc_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("rfc_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("rfc_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("rfc_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }

        }
    }

    public void EntertheUniverse_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("entertheuniverse_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("entertheuniverse_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("entertheuniverse_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("entertheuniverse_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void UAD_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("UAD_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("UAD_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("UAD_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("UAD_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void Lightfall_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("LightFall_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("Lightfall_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("LightFall_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("Lightfall_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void Godmode_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("godmode_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("godmode_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("godmode_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("godmode_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void Bedlam_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("bedlam_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("bedlam_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("bedlam_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("bedlam_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void nice_shot_score()
    {
        if (!IsSelectHard)
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("nice_shot_MAXscore_NM").ToString();
            if (PlayerPrefs.HasKey("nice_shot_NM_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
        else
        {
            HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("nice_shot_MAXscore_HD").ToString();
            if (PlayerPrefs.HasKey("nice_shot_HD_AllCombo"))
            {
                AllCombo_Img.SetActive(true);
            }
            else
            {
                AllCombo_Img.SetActive(false);
            }
        }
    }

    public void Equipment()
    {
        SceneManager.LoadScene("Store");
    }

    public void Collection()
    {
        SceneManager.LoadScene("Collection");
    }

    public void EarlyPlay(string MusicName)
    {
        if (MusicPlayer.GetComponent<AudioSource>().isPlaying)
        {
            MusicPlayer.GetComponent<AudioSource>().Stop();
        }
        AudioClip bgm = Resources.Load("BGM/" + MusicName) as AudioClip;
        MusicPlayer.GetComponent<AudioSource>().clip = bgm;

        int a = MusicPlayer.GetComponent<AudioSource>().clip.frequency;

        MusicPlayer.GetComponent<AudioSource>().timeSamples = a * 30;
        MusicPlayer.GetComponent<AudioSource>().volume = 0.4f;
        MusicPlayer.GetComponent<AudioSource>().Play();
        


    }
}