using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plate_Color : MonoBehaviour {
    // 프로필 플레이트 커스텀마이징 스크립트

    public GameObject Panel1; //Default color
    public GameObject Panel2; //Red
    public GameObject Panel3; //Mag
    public GameObject Panel4; //Mint
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8;
    public GameObject Panel9;
    public GameObject Panel10;

    public Color32 Panel1_Color;
    public Color32 Panel2_Color;
    public Color32 Panel3_Color;
    public Color32 Panel4_Color;
    public Color32 Panel5_Color;
    public Color32 Panel6_Color;
    public Color32 Panel7_Color;
    public Color32 Panel8_Color;
    public Color32 Panel9_Color;
    public Color32 Panel10_Color;

    public int Color_Switch = 0;

    // Use this for initialization
    void Start () {
        Color_Switch = PlayerPrefs.GetInt("Color_Switch");

        Panel1_Color = Panel1.GetComponent<Image>().color;
        Panel2_Color = Panel2.GetComponent<Image>().color;
        Panel3_Color = Panel3.GetComponent<Image>().color;
        Panel4_Color = Panel4.GetComponent<Image>().color;
        Panel5_Color = Panel5.GetComponent<Image>().color;
        Panel6_Color = Panel6.GetComponent<Image>().color;
        Panel7_Color = Panel7.GetComponent<Image>().color;
        Panel8_Color = Panel8.GetComponent<Image>().color;
        Panel9_Color = Panel9.GetComponent<Image>().color;
        Panel10_Color = Panel10.GetComponent<Image>().color;
    }
	
	// Update is called once per frame
	void Update () {
		if(Color_Switch == 0)
        {
            this.GetComponent<Image>().color = Panel1_Color;
        }

        if (Color_Switch == 1)
        {
            this.GetComponent<Image>().color = Panel2_Color;
        }

        if (Color_Switch == 2)
        {
            this.GetComponent<Image>().color = Panel3_Color;
        }

        if (Color_Switch == 3)
        {
            this.GetComponent<Image>().color = Panel4_Color;
        }

        if (Color_Switch == 4)
        {
            this.GetComponent<Image>().color = Panel5_Color;
        }

        if (Color_Switch == 5)
        {
            this.GetComponent<Image>().color = Panel6_Color;
        }

        if (Color_Switch == 6)
        {
            this.GetComponent<Image>().color = Panel7_Color;
        }

        if (Color_Switch == 7)
        {
            this.GetComponent<Image>().color = Panel8_Color;
        }

        if (Color_Switch == 8)
        {
            this.GetComponent<Image>().color = Panel9_Color;
        }

        if (Color_Switch == 9)
        {
            this.GetComponent<Image>().color = Panel10_Color;
        }
    }

    public void SwitchColor1()
    {
        Color_Switch = 0;
        SwitchPrefs();
    }

    public void SwitchColor2()
    {
        Color_Switch = 1;
        SwitchPrefs();
    }

    public void SwitchColor3()
    {
        Color_Switch = 2;
        SwitchPrefs();
    }

    public void SwitchColor4()
    {
        Color_Switch = 3;
        SwitchPrefs();
    }

    public void SwitchColor5()
    {
        Color_Switch = 4;
        SwitchPrefs();
    }

    public void SwitchColor6()
    {
        Color_Switch = 5;
        SwitchPrefs();
    }

    public void SwitchColor7()
    {
        Color_Switch = 6;
        SwitchPrefs();
    }

    public void SwitchColor8()
    {
        Color_Switch = 7;
        SwitchPrefs();
    }

    public void SwitchColor9()
    {
        Color_Switch = 8;
        SwitchPrefs();
    }

    public void SwitchColor10()
    {
        Color_Switch = 9;
        SwitchPrefs();
    }

    public void SwitchPrefs()
    {
        PlayerPrefs.SetInt("Color_Switch", Color_Switch);
    }
}
