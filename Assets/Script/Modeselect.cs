using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Modeselect : MonoBehaviour {

    public GameObject FreeUI;
    public GameObject MissionUI;
    public GameObject NetworkUI;
    public GameObject OptionUI;

    // 모드 선택시 공통으로 SetActive 조정되는 변수들
    public GameObject musicplayer;
    public GameObject freemode_video;
    public GameObject Canvas;

    public GameObject tutorial_video;
    public GameObject mission_video;
    public GameObject option_video;
    public GameObject network_video;

    //선택 스타터
    public GameObject FreeStarter;
    public GameObject TutorialStarter;
    public GameObject MissionStarter;
    public GameObject NetworkStarter;
    public GameObject OptionStarter;

    bool free = true; //프리 선택 한 장면에 튜토리얼 버튼도 들어갈거임
    bool mission = false;
    bool network = false;

    int Switch = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("1"))
        {
            Switch = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            Switch = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            Switch = 3;
        }
        if (Input.GetKeyDown("4"))
        {
            Switch = 4;
        }

        /*   // 1107 테스터가 오른손을 방향키에 올려놓는걸 보아 좌우키로 해결하려 했는데 잘 안됨.. 이건 이거대로 후에 하고 일단 1,2,3,4를 조작키로도 사용 할 수 있게 하는걸로
        if (Input.GetKeyDown("left") && Switch == 1)
        {
            Switch = 3;
        }
        if (Input.GetKeyDown("right") && Switch == 1)
        {

            Switch = 2;

        } //Free 메인일때 좌방향키 : Network / 우방향키 : Mission


        if (Input.GetKeyDown("left") && Switch == 2)
        {
            Switch = 1;
        }
        if (Input.GetKeyDown("right") && Switch == 2)
        {
            Switch = 3;

        } //Mission 메인일때 좌방향키 : Free / 우방향키 : Network


        if (Input.GetKeyDown("left") && Switch == 3)
        {

            Switch = 2;
        }
        if (Input.GetKeyDown("right") && Switch == 3)
        {

            Switch = 1;

        } //Mission 메인일때 좌방향키 : Mission / 우방향키 : Free
        */
        if (Switch == 1)
        {
            FreeUI.SetActive(true);
        }
        else if (Switch != 1)
        {
            FreeUI.SetActive(false);
        }

        if (Switch == 2)
        {
            MissionUI.SetActive(true);
        }
        else if (Switch != 2)
        {
            MissionUI.SetActive(false);
        }

        if (Switch == 3)
        {
            NetworkUI.SetActive(true);
        }
        else if (Switch != 3)
        {
            NetworkUI.SetActive(false);
        }

        if (Switch == 4)
        {
            OptionUI.SetActive(true);
        }
        else if (Switch != 4)
        {
            OptionUI.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Switch == 1)
            {
               Free_Starter();
            }
            else if (Switch == 2)
            {
                Mission_Starter();
            }
            else if (Switch == 3)
            {
                Network_Starter();
            }
            else if (Switch == 4)
            {
                Option_Starter();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Switch == 1)
            {
                Tutorial_Starter();
                // 튜토리얼 시작
            }
        }
    }

    public void General_Starter()
    {
        GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
        musicplayer.SetActive(true);
        Canvas.SetActive(false);
    }

    public void Free_Starter()
    {
        freemode_video.SetActive(true);
        General_Starter();
        FreeStarter.SetActive(true);
    }
    public void Tutorial_Starter()
    {
        tutorial_video.SetActive(true);
        General_Starter();
        TutorialStarter.SetActive(true);
    }
    public void Mission_Starter()
    {
        mission_video.SetActive(true);
        General_Starter();
        MissionStarter.SetActive(true);
    }
    public void Network_Starter()
    {
        network_video.SetActive(true);
        General_Starter();
        NetworkStarter.SetActive(true);
    }
    public void Option_Starter()
    {
        SceneManager.LoadScene("Option");
    }
}

