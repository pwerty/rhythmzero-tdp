using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modeselect_TimeChecker : MonoBehaviour {

    public GameObject FreeUI;
    public GameObject MissionUI;
    public GameObject NetworkUI;


    bool free = true; //프리 선택 한 장면에 튜토리얼 버튼도 들어갈거임
    bool mission = false;
    bool network = false;

    int Switch = 1;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

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

    }
}
