using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingame_CustomSett : MonoBehaviour {

    public GameObject PlaySpeedButton_Text;
    public GameObject NoteTypeButton_Text;
    public GameObject VideoToggleButton_Text;
    public GameObject GearPosition_Text;
    public GameObject GrooveLightButton_Text;

    public GameObject PlaySpeedButton;
    public GameObject NoteTypeButton;
    public GameObject VideoToggleButton;
    public GameObject GearPositionButton;
    public GameObject GrooveLightButton;

    public Text Speed;

   static public float PlaySpeed = 1.0f;

    public int NoteType_Switch; //노트 타입은 일반, 미러, 랜덤 3옵션이 있어 int로 사용
    public int GearPosition_Switch; // 0은 Left, 1은 Center, 2는 Right
    public bool VideoToggle_Switch;

    public bool GrooveLight_Switch;

    // Use this for initialization
    void Start()
    {
        if(PlayerPrefs.HasKey("NoteType_Switch") == false)
        {
            PlayerPrefs.SetInt("NoteType_Switch", NoteType_Switch);
        }

        if(PlayerPrefs.HasKey("VideoToggle_Switch") == false)
        {
            PlayerPrefs.SetString("VideoToggle_Switch", "true");
        }

        if(PlayerPrefs.HasKey("GrooveLight_Switch") == false)
        {
            PlayerPrefs.SetString("GrovveLight_Switch", "true");
        }

        if (PlayerPrefs.HasKey("GearPosition_Switch") == false)
        {
            PlayerPrefs.SetInt("GearPosition_Switch", 1);
        }

        NoteType_Switch = PlayerPrefs.GetInt("NoteType_Switch");
        GearPosition_Switch = PlayerPrefs.GetInt("GearPosition_Switch");
        VideoToggle_Switch = bool.Parse(PlayerPrefs.GetString("VideoToggle_Switch"));

        GrooveLight_Switch = bool.Parse(PlayerPrefs.GetString("GrooveLight_Switch"));


    }
	
	// Update is called once per frame
	void Update () {
        Speed.text = PlaySpeed + "x";

        if (NoteType_Switch == 0)
        {
            NoteTypeButton_Text.GetComponent<Text>().text = "Default";
            PlayerPrefs.SetInt("NoteType_Switch", NoteType_Switch);
        }
        else if(NoteType_Switch == 1)
        {
            NoteTypeButton_Text.GetComponent<Text>().text = "MIRROR";
            PlayerPrefs.SetInt("NoteType_Switch", NoteType_Switch);
        }
        else if(NoteType_Switch == 2)
        {
            NoteTypeButton_Text.GetComponent<Text>().text = "RANDOM";
            PlayerPrefs.SetInt("NoteType_Switch", NoteType_Switch);
        }

        if (GearPosition_Switch == 0)
        {
            GearPosition_Text.GetComponent<Text>().text = "Left";
            PlayerPrefs.SetInt("GearPosition_Switch", GearPosition_Switch);
        }
        else if (GearPosition_Switch == 1)
        {
            GearPosition_Text.GetComponent<Text>().text = "Center";
            PlayerPrefs.SetInt("GearPosition_Switch", GearPosition_Switch);
        }
        else if (GearPosition_Switch == 2)
        {
            GearPosition_Text.GetComponent<Text>().text = "Right";
            PlayerPrefs.SetInt("GearPosition_Switch", GearPosition_Switch);
        }

        if (VideoToggle_Switch == true)
        {
            VideoToggleButton_Text.GetComponent<Text>().text = "Video is.. \n On";
            PlayerPrefs.SetString("VideoToggle_Switch", "true");
        }
        else
        {
            VideoToggleButton_Text.GetComponent<Text>().text = "Video is.. \n Off";
            PlayerPrefs.SetString("VideoToggle_Switch", "false");
        }
      

        if (GrooveLight_Switch)
        {
            GrooveLightButton_Text.GetComponent<Text>().text = "Groove Light \n On";
            PlayerPrefs.SetString("GrooveLight_Switch", "true");
        }
        else
        {
            GrooveLightButton_Text.GetComponent<Text>().text = "Groove Light \n Off";
            PlayerPrefs.SetString("GrooveLight_Switch", "false");
        }

        if(Input.GetKeyDown(KeyCode.LeftBracket))
        {
            PlaySpeed_Down_();
        }

        if(Input.GetKeyDown(KeyCode.RightBracket))
        {
            PlaySpeed_UP_();
        }

    }

    public void Started()
    {
        NoteBar_.PlaySpeed = PlaySpeed;
        Falling_From.Video_Settings = VideoToggle_Switch;
        Ingame_Custom_Reciever.Groove_Settings = GrooveLight_Switch;
    }

    public void PlaySpeed_UP_()
    {
        if (PlaySpeed >= 2.0f)
        {
            print("더 증가 시킬 수 없습니다.");
        }
        else
        {
            PlaySpeed += 0.1f;
        }
    }

    public void PlaySpeed_Down_()
    {
        if (PlaySpeed <= 1.0f)
        {
            print("더 감소 시킬 수 없습니다.");
        }
        else
        {
            PlaySpeed -= 0.1f;
        }
    }

    public void NoteType_()
    {
        if(NoteType_Switch == 0)
        {
            NoteType_Switch = 1;
        }
        else if(NoteType_Switch == 1)
        {
            NoteType_Switch = 2;
        }
        else if(NoteType_Switch == 2)
        {
            NoteType_Switch = 0;
        }
    }

    public void VideoToggle_()
    {
        if(VideoToggle_Switch == false)
        {
            VideoToggle_Switch = true;
        }
        else
        {
            VideoToggle_Switch = false;
        }
    }
    
    public void GearPosition_()
    {
        if (GearPosition_Switch == 0)
        {
            GearPosition_Switch = 1;
        }
        else if (GearPosition_Switch == 1)
        {
            GearPosition_Switch = 2;
        }
        else if (GearPosition_Switch == 2)
        {
            GearPosition_Switch = 0;
        }
    }

    public void GrooveLight_()
    {
        if (GrooveLight_Switch == false)
        {
            GrooveLight_Switch = true;
        }
        else
        {
            GrooveLight_Switch = false;
        }

    }
}
