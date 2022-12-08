using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pressing : MonoBehaviour {

    public GameObject CanCapture;
    public GameObject EnterToEvent;

    public bool CanGoNext;
    public bool CanGoSelect;

    public Text Nice_or_Not;

    bool IsCaptured = false;
	// Use this for initialization
  

	void Start () {
        CanGoNext = false;
        CanGoSelect = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && IsCaptured == false)
        {
            Application.CaptureScreenshot(System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() + "Screenshot.png");
            IsCaptured = true;
            CanCapture.GetComponent<Text>().text = "캡쳐가 완료되었습니다.";

            // 바탕화면에 할 수 있다면 좋을텐데
        }

        if (MissionManager.CanPlayNext && Combo.IsMissionPlaying)
        {
            if (Mission.Mission_Switcher == 1)
            {
                if (MissionManager.Mission1_Stage_Count == MissionManager.StageCount)
                {
                    Text_AllClear();
                    EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 미션 선택 창으로 이동합니다.";
                    CanGoSelect = true;
                    PlayerPrefs.SetInt("IsClear1stMission_dev", 2);

                }
                else
                {
                    Text_StageClear();
                    EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 다음 스테이지가 시작됩니다.";
                    CanGoNext = true;

                }
            }

            else if (Mission.Mission_Switcher == 7)
            {
                if (MissionManager.Mission7_Stage_Count == MissionManager.StageCount)
                {
                    Text_AllClear();
                    EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 미션 선택 창으로 이동합니다.";
                    CanGoSelect = true;
                    PlayerPrefs.SetInt("IsClear7thMission_dev", 2); //1219 should modify // 원래는 1번임 임시로 2번

                }
                else
                {
                    Text_StageClear();
                    EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 다음 스테이지가 시작됩니다.";
                    CanGoNext = true;

                }
            }/*
            else if (Combo.IsMissionPlaying)
            {
                Nice_or_Not.text = "asdasd";
                EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 해당 미션을 처음부터 재도전합니다.";
                CanGoNext = false;
                
            }*/


            // 아무것도 안한다



        }
        else if (Combo.IsMissionPlaying)
        {
            Text_Failed();
            EnterToEvent.GetComponent<Text>().text = "엔터 키를 누르면 해당 미션을 처음부터 재도전합니다.";
            CanGoNext = false;

        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(SceneManager.GetActiveScene().name == "Mission_result")
            {
                if(CanGoSelect)
                {
                    SceneManager.LoadScene("Mission_mode");
                }
                else if(CanGoNext)
                {
                    MissionManager.NextStart();
                }


                if(CanGoSelect == false && CanGoNext == false)
                {
                    Mission.MissionStart();
                }
            }
            else
            {
                SceneManager.LoadScene("Free_select");
            }

            
          //  
           // //스페이스를 재도전, 엔터가 선택창으로 이동 
          //  
        }

	}

    public void Text_AllClear()
    {
        Nice_or_Not.text = "ALL CLEAR";
    }

    public void Text_StageClear()
    {
        Nice_or_Not.text = "STAGE CLEAR";
    }

    public void Text_Failed()
    {
        Nice_or_Not.text = "FAILED";
    }
}
