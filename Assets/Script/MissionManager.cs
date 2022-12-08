using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour {

    // 미션모드에 들어오면 1스테이지 이후 스테이지 이동시켜주는 스크립트들
    // 1스테이지는 Mission 선택 씬에 Mission.cs에 있음


    public bool MissionManger_Active;

    static public string bmsName;
    static public int StageCount = 1;
    static public bool IsSelectHard;
    static public bool IsPlayerReady;
    static public bool CanPlayNext;

    static public int Mission1_Stage_Count;
    static public int Mission7_Stage_Count;

    public int MissionManager_Switcher;

    public bool Is_1st_started;
    public bool Is_2nd_started;
    public bool Is_3rd_started;

    public Text MissionName;
    public Text StageInfo;

	// Use this for initialization
	void Start () {
        MissionManger_Active = Combo.IsMissionPlaying;
        MissionManager_Switcher = Mission.Mission_Switcher_Static;
        IsPlayerReady = false;
        CanPlayNext = false;
        Mission1_Stage_Count = 3; //플레이 스테이지 갯수 + 결과 트리거
        Mission7_Stage_Count = 2;
    }
	
	// Update is called once per frame
	void Update () {
		if(MissionManger_Active)
        {
            if (MissionManager_Switcher == 1)
            {

                MissionName.text = "Bon Appetit";
                StageInfo.text = "STAGE " + (StageCount - 1).ToString();
                if (StageCount == 2 &&/* Is_2nd_started == false && */IsPlayerReady && CanPlayNext)
                {
                    MissionName.text = "Bon Appetit";
                    StageInfo.text = "STAGE " + (StageCount - 1).ToString();
                    NoteBar_.bmsName = "deborah";
                    NoteBar_.IsSelectHard = false;
                    SceneManager.LoadScene("prev_modify_tutorial");
                    //Is_2nd_started = true; 
                    //                     SceneManager.LoadScene("prev_modify_tutorial");
                }
                else if (StageCount == 3)
                {
                    MissionName.text = "Bon Appetit";
                    StageInfo.text = "STAGE " + (StageCount - 1).ToString();
                }
            }
            else if (MissionManager_Switcher == 2)
            {

            }
            else if (MissionManager_Switcher == 3)
            {

            }
            else if (MissionManager_Switcher == 4)
            {

            }
            else if (MissionManager_Switcher == 5)
            {

            }
            else if (MissionManager_Switcher == 6)
            {

            }
            else if (MissionManager_Switcher == 7)
            {
                MissionName.text = "as same as";
                StageInfo.text = "STAGE " + (StageCount - 1).ToString();
                if (StageCount == 2)
                {
                    MissionName.text = "Bon Appetit";
                    StageInfo.text = "STAGE " + (StageCount - 1).ToString();
                }
            }
            else if (MissionManager_Switcher == 8)
            {

            }
            else if (MissionManager_Switcher == 9)
            {

            }
            else if (MissionManager_Switcher == 10)
            {

            }

        }
        else
        {
            gameObject.SetActive(false);
        }

       

    }

    static public void NextStage()
    {
        StageCount++;
    }

    static public void NextStart()
    {
        IsPlayerReady = true;
    }

    static public void PrevStage()
    {
        StageCount--;
    }
}
