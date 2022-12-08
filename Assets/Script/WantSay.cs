using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WantSay : MonoBehaviour {
    // 한마디 커스텀마이징 스크립트

    // Use this for initialization

    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;
    public Text txt6;
    public Text txt7;

    public Text txt1_button;
    public Text txt2_button;
    public Text txt3_button;
    public Text txt4_button;
    public Text txt5_button;
    public Text txt6_button;
    public Text txt7_button;


    public int Text_Switch;

    void Start () {
        if (PlayerPrefs.HasKey("Text_Switch"))
        {
            Text_Switch = PlayerPrefs.GetInt("Text_Switch");
        }
        else
        {
            PlayerPrefs.SetInt("Text_Switch", 0);
            Text_Switch = PlayerPrefs.GetInt("Text_Switch");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Text_Switch == 0)
        {
            this.GetComponent<Text>().text = txt1.text;
            txt1_button.text = "착용됨";
        }
        else
        {
            txt1_button.text = "-";
        }

        if (Text_Switch == 1)
        {
            this.GetComponent<Text>().text = txt2.text;
            txt2_button.text = "착용됨";
        }
        else
        {
            txt2_button.text = "-";
        }

        if (Text_Switch == 2)
        {
            this.GetComponent<Text>().text = txt3.text;
            txt3_button.text = "착용됨";
        }
        else
        {
            txt3_button.text = "-";
        }

        if (Text_Switch == 3)
        {
            this.GetComponent<Text>().text = txt4.text;
            txt4_button.text = "착용됨";
        }
        else
        {
            txt4_button.text = "-";
        }

        if (Text_Switch == 4)
        {
            this.GetComponent<Text>().text = txt5.text;
            txt5_button.text = "착용됨";
        }
        else
        {
            txt5_button.text = "-";
        }

        if (Text_Switch == 5)
        {
            this.GetComponent<Text>().text = txt6.text;
            txt6_button.text = "착용됨";
        }
        else
        {
            txt6_button.text = "-";
        }

        if (Text_Switch == 6)
        {
            this.GetComponent<Text>().text = txt7.text;
            txt7_button.text = "착용됨";
        }
        else
        {
            txt7_button.text = "-";
        }

    }

    public void Switch1()
    {
        Text_Switch = 0;
        SwitchPrefs();
    }

    public void Switch2()
    {
        Text_Switch = 1;
        SwitchPrefs();
    }

    public void Switch3()
    {
        Text_Switch = 2;
        SwitchPrefs();
    }

    public void Switch4()
    {
        Text_Switch = 3;
        SwitchPrefs();
    }

    public void Switch5()
    {
        Text_Switch = 4;
        SwitchPrefs();
    }

    public void Switch6()
    {
        Text_Switch = 5;
        SwitchPrefs();
    }

    public void Switch7()
    {
        Text_Switch = 6;
        SwitchPrefs();
    }

    public void SwitchPrefs()
    {
        PlayerPrefs.SetInt("Text_Switch", Text_Switch);
    }
}
