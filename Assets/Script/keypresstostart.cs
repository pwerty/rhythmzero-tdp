using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class keypresstostart : MonoBehaviour
{

    public GameObject StartCube;
    public GameObject MusicPlayer;
    public GameObject StartText;

    static public bool HaveNickname;
    public GameObject Nickname_button;
    public InputField Nickname;
    public Text Message;
    public GameObject NicknameSettingPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("HaveName") == false)
        {
            NicknameSettingPanel.SetActive(true);
        }
        else
        {
            HaveNickname = true;
            NicknameSettingPanel.SetActive(false);
        }

        if(HaveNickname == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SendMessage("Title_startit");

            }
            if (StartCube.GetComponent<AudioSource>().isPlaying == false && StartCube.activeSelf == true)
            {
                SceneManager.LoadScene("modeselect");
            }
        }

    }

    void Title_startit()
    {
        StartCube.SetActive(true);
        StartText.SetActive(true);
        MusicPlayer.GetComponent<AudioSource>().Stop();
    }

    public void Nickname_()
    {
        if(Nickname.text == "")
        {
            Message.text = "닉네임을 입력하세요.";
        }
        else
        {
            print("ㅁㄴㅇㅁㄴㅇ");
            HaveNickname = true;
            PlayerPrefs.SetString("name", Nickname.text);
            PlayerPrefs.SetString("HaveName", "true");
        }
    }
}
