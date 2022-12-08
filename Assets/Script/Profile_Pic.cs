using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile_Pic : MonoBehaviour {
    // 프로필 캐릭터 커스텀마이징 스크립트

    public Texture Profile1; // 아직 예명입니다.
    public Texture Profile2;
    public Texture Profile3;
    public Texture Profile4;
    public Texture Profile5;
    public Texture Profile6;
    public Texture Profile7;
    public Texture Profile8;
    public Texture Profile9;
    public Texture Profile10;
    public Texture Profile11;


    public Text Profile1_button;
    public Text Profile2_button;
    public Text Profile3_button;
    public Text Profile4_button;
    public Text Profile5_button;
    public Text Profile6_button;
    public Text Profile7_button;
    public Text Profile8_button;
    public Text Profile9_button;
    public Text Profile10_button;
    public Text Profile11_button;

    public int Profile_Pic_Switch;
	// Use this for initialization
	void Start () {
        Profile_Pic_Switch = PlayerPrefs.GetInt("Char_Switch");

    }
	
	// Update is called once per frame
	void Update () {
		if (Profile_Pic_Switch == 0)
        {
            this.GetComponent<RawImage>().texture = Profile1;
            Profile1_button.text = "NOW";
            Profile1_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile1_button.text = "Punch Man";
            Profile1_button.fontStyle = FontStyle.Normal;
            
        }

        if (Profile_Pic_Switch == 1)
        {
            this.GetComponent<RawImage>().texture = Profile2;
            Profile2_button.text = "NOW";
            Profile2_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile2_button.text = "Genos";
            Profile2_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 2)
        {
            this.GetComponent<RawImage>().texture = Profile3;
            Profile3_button.text = "NOW";
            Profile3_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile3_button.text = "Silver Fang";
            Profile3_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 3)
        {
            this.GetComponent<RawImage>().texture = Profile4;
            Profile4_button.text = "NOW";
            Profile4_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile4_button.text = "Pororo";
            Profile4_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 4)
        {
            this.GetComponent<RawImage>().texture = Profile5;
            Profile5_button.text = "NOW";
            Profile5_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile5_button.text = "VON_GOD";
            Profile5_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 5)
        {
            this.GetComponent<RawImage>().texture = Profile6;
            Profile6_button.text = "NOW";
            Profile6_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile6_button.text = "Tom";
            Profile6_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 6)
        {
            this.GetComponent<RawImage>().texture = Profile7;
            Profile7_button.text = "NOW";
            Profile7_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile7_button.text = "Spike";
            Profile7_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 7)
        {
            this.GetComponent<RawImage>().texture = Profile8;
            Profile8_button.text = "NOW";
            Profile8_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile8_button.text = "Jerry";
            Profile8_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 8)
        {
            this.GetComponent<RawImage>().texture = Profile9;
            Profile9_button.text = "NOW";
            Profile9_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile9_button.text = "Yun Woo";
            Profile9_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 9)
        {
            this.GetComponent<RawImage>().texture = Profile10;
            Profile10_button.text = "NOW";
            Profile10_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile10_button.text = "Kang Hee";
            Profile10_button.fontStyle = FontStyle.Normal;
        }

        if (Profile_Pic_Switch == 10)
        {
            this.GetComponent<RawImage>().texture = Profile11;
            Profile11_button.text = "NOW";
            Profile11_button.fontStyle = FontStyle.Bold;
        }
        else
        {
            Profile11_button.text = "Coca-Bear";
            Profile11_button.fontStyle = FontStyle.Normal;
        }

        /*
                if (Profile_Pic_Switch == 3)
                {
                    this.GetComponent<RawImage>().texture = Profile3;
                    Profile3_button.text = "NOW";
                }
                else
                {
                    Profile3_button.text = "Silver Fang";
                }

                if (Profile_Pic_Switch == 4)
                {
                    this.GetComponent<RawImage>().texture = Profile3;
                    Profile3_button.text = "NOW";
                }
                else
                {
                    Profile3_button.text = "Silver Fang";
                }

                if (Profile_Pic_Switch == 5)
                {
                    this.GetComponent<RawImage>().texture = Profile3;
                    Profile3_button.text = "NOW";
                }
                else
                {
                    Profile3_button.text = "Silver Fang";
                }

                if (Profile_Pic_Switch == 6)
                {
                    this.GetComponent<RawImage>().texture = Profile3;
                    Profile3_button.text = "NOW";
                }
                else
                {
                    Profile3_button.text = "Silver Fang";
                }
                */
    }

    public void SwitchToPunchMan()
    {
        Profile_Pic_Switch = 0;
        PlayerPrefs.SetInt("Char_Switch", 0);
    }

    public void SwitchToGenos()
    {
        Profile_Pic_Switch = 1;
        PlayerPrefs.SetInt("Char_Switch", 1);
    }

    public void SwitchToSilverFang()
    {
        Profile_Pic_Switch = 2;
        PlayerPrefs.SetInt("Char_Switch", 2);
    }
    
    public void SwitchToPororo()
    {
        Profile_Pic_Switch = 3;
        PlayerPrefs.SetInt("Char_Switch", 3);
    }

    public void SwitchToVONGOD()
    {
        Profile_Pic_Switch = 4;
        PlayerPrefs.SetInt("Char_Switch", 4);
    }

    public void SwitchToTom()
    {
        Profile_Pic_Switch = 5;
        PlayerPrefs.SetInt("Char_Switch", 5);
    }

    public void SwitchToSpike()
    {
        Profile_Pic_Switch = 6;
        PlayerPrefs.SetInt("Char_Switch", 6);
    }

    public void SwitchToJerry()
    {
        Profile_Pic_Switch = 7;
        PlayerPrefs.SetInt("Char_Switch", 7);
    }

    public void SwitchToYunWoo()
    {
        Profile_Pic_Switch = 8;
        PlayerPrefs.SetInt("Char_Switch", 8);
    }

    public void SwitchToKangHee()
    {
        if(PlayerPrefs.GetInt("Player_Exp") >= 350)
        {
            Profile_Pic_Switch = 9;
            PlayerPrefs.SetInt("Char_Switch", 9);
        }
        else
        {

        }

    }

    public void SwitchToCocaBear()
    {
        if (PlayerPrefs.GetInt("Achieve1_dev_") == 1)
        {
            Profile_Pic_Switch = 10;
            PlayerPrefs.SetInt("Char_Switch", 10);
        }
        else
        {

        }

    }


}
