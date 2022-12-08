using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mission : MonoBehaviour {

    public bool CanPlay7th;

    public GameObject Button;

    public GameObject Mission1;
    public GameObject Mission2;
    public GameObject Mission3;
    public GameObject Mission4;
    public GameObject Mission5;
    public GameObject Mission6;
    public GameObject Mission7;
    public GameObject Mission8;
    public GameObject Mission9;
    public GameObject Mission10;

    public GameObject Selected;

    public Text Introduce;

    static public int Mission_Switcher = 1;
    static public int Mission_Switcher_Static;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mission_Switcher == 1)
        {
            Selected.GetComponent<Image>().sprite = Mission1.GetComponent<Image>().sprite;
            Mission1.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "맛있게 드세요.";
            Button.SetActive(true);
        }
        else
        {
            Mission1.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 2)
        {
            Selected.GetComponent<Image>().sprite = Mission2.GetComponent<Image>().sprite;
            Mission2.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission2.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 3)
        {
            Selected.GetComponent<Image>().sprite = Mission3.GetComponent<Image>().sprite;
            Mission3.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission3.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 4)
        {
            Selected.GetComponent<Image>().sprite = Mission4.GetComponent<Image>().sprite;
            Mission4.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission4.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 5)
        {
            Selected.GetComponent<Image>().sprite = Mission5.GetComponent<Image>().sprite;
            Mission5.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission5.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 6)
        {
            Selected.GetComponent<Image>().sprite = Mission6.GetComponent<Image>().sprite;
            Mission6.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission6.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 7)
        {
            Selected.GetComponent<Image>().sprite = Mission7.GetComponent<Image>().sprite;
            Mission7.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);

            if (PlayerPrefs.GetInt("IsClear1stMission_dev") == 2)
            {
                CanPlay7th = true;
                Introduce.text = "우연의 일치";
                Button.SetActive(true);
            }
            else
            {
                Introduce.text = "1번 미션을 우선 클리어 하셔야 합니다.";
                Button.SetActive(false);
            }
        }
        else
        {
            Mission7.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 8)
        {
            Selected.GetComponent<Image>().sprite = Mission8.GetComponent<Image>().sprite;
            Mission8.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission8.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 9)
        {
            Selected.GetComponent<Image>().sprite = Mission9.GetComponent<Image>().sprite;
            Mission9.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission9.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }

        if (Mission_Switcher == 10)
        {
            Selected.GetComponent<Image>().sprite = Mission10.GetComponent<Image>().sprite;
            Mission10.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0xff);
            Introduce.text = "아직 플레이 할 수 없습니다.";
            Button.SetActive(true);
        }
        else
        {
            Mission10.GetComponent<Image>().color = new Color32(0xff, 0xff, 0xff, 0x64);
        }
        Mission_Switcher_Static = Mission_Switcher;
    }

    public void SwitchMission1()
    {
        Mission_Switcher = 1;
    }

    public void SwitchMission2()
    {
        Mission_Switcher = 2;
    }

    public void SwitchMission3()
    {
        Mission_Switcher = 3;
    }

    public void SwitchMission4()
    {
        Mission_Switcher = 4;
    }

    public void SwitchMission5()
    {
        Mission_Switcher = 5;
    }

    public void SwitchMission6()
    {
        Mission_Switcher = 6;
    }

    public void SwitchMission7()
    {
        Mission_Switcher = 7;
    }

    public void SwitchMission8()
    {
        Mission_Switcher = 8;
    }

    public void SwitchMission9()
    {
        Mission_Switcher = 9;
    }

    public void SwitchMission10()
    {
        Mission_Switcher = 10;
    }

   static public void MissionStart()
    {

        if (Mission_Switcher == 1)
        {
            NoteBar_.bmsName = "rfc";
           NoteBar_.IsSelectHard = false;
            SceneManager.LoadScene("prev_modify_tutorial");
            Combo.IsMissionPlaying = true; //Free mode 가서 플레이때 false 선언
            MissionManager.StageCount = 1;
        }
        
        else if (Mission_Switcher == 2)
        {

        }
        else if (Mission_Switcher == 3)
        {

        }
        else if (Mission_Switcher == 4)
        {

        }
        else if (Mission_Switcher == 5)
        {

        }
        else if (Mission_Switcher == 6)
        {

        }
        else if (Mission_Switcher == 7)
        {
            NoteBar_.bmsName = "frozen_eyes";
            NoteBar_.IsSelectHard = false;
            SceneManager.LoadScene("prev_modify_tutorial");
            Combo.IsMissionPlaying = true; //Free mode 가서 플레이때 false 선언
            MissionManager.StageCount = 1;
        }
        else if (Mission_Switcher == 8)
        {

        }
        else if (Mission_Switcher == 9)
        {

        }
        else if (Mission_Switcher == 10)
        {

        }
       /* SceneManager.LoadScene("prev_modify_tutorial");
        Combo.IsMissionPlaying = true; //Free mode 가서 플레이때 false 선언
        MissionManager.StageCount = 1;*/
    //1,7번을 제외한 미션이 비어 있으니 우선은 1번과 7번만 따로따로 써놓는다
    }

    public void MissionBegin()
    {
        MissionStart();
        //미션 스위치 전송

    }
}
