using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note_Admin : MonoBehaviour {

    public Text Note1;
    public Text Note2;
    public Text Note3;
    public Text Note4;

    public int Note_Switch = 0;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("Note_Switch"))
        {
            Note_Switch = PlayerPrefs.GetInt("Note_Switch");
        }
        else
        {
            PlayerPrefs.SetInt("Note_Switch", 0);
            Note_Switch = PlayerPrefs.GetInt("Note_Switch");
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (Note_Switch == 0)
        {
            Note1.GetComponent<Text>().text = "활성화";
        }
        else
        {
            Note1.GetComponent<Text>().text = "-";
        }

        if (Note_Switch == 1)
        {
            Note2.GetComponent<Text>().text = "활성화";
        }
        else
        {
            Note2.GetComponent<Text>().text = "-";
        }

        if (Note_Switch == 2)
        {
            Note3.GetComponent<Text>().text = "활성화";
        }
        else
        {
            Note3.GetComponent<Text>().text = "-";
        }

        if (Note_Switch == 3)
        {
            Note4.GetComponent<Text>().text = "활성화";
        }
        else
        {
            Note4.GetComponent<Text>().text = "-";
        }
    }

    public void SwitchToNote1()
    {
        Note_Switch = 0;
        Switch_Final();
    }
    
    public void SwitchToNote2()
    {
        Note_Switch = 1;
        Switch_Final();
    }

    public void SwitchToNote3()
    {
        Note_Switch = 2;
        Switch_Final();
    }

    public void SwitchToNote4()
    {
        Note_Switch = 2;
        Switch_Final();
    }

    public void Switch_Final()
    {
        PlayerPrefs.SetInt("Note_Switch", Note_Switch);
    }
}
