using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nickname_Admin : MonoBehaviour {

    public GameObject Nickname_button;
    public InputField Nickname;
    public Text Message;
    public GameObject NicknameSettingPanel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Nickname_()
    {
        if (Nickname.text == "")
        {
            Message.text = "닉네임을 입력하세요.";
        }
        else
        {
            print("ㅁㄴㅇㅁㄴㅇ");
            PlayerPrefs.SetString("name", Nickname.text);
            PlayerPrefs.SetString("HaveName", "true");
            NicknameSettingPanel.SetActive(false);
        }
    }
}
