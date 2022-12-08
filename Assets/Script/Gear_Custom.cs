using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear_Custom : MonoBehaviour {

    public GameObject Gear1; //기본
    public GameObject Gear2; //WhiteRed
    public GameObject Gear3; //JetStream
    public GameObject Gear4; //Mint
    public GameObject Gear5; //Yellow
    public GameObject Gear6; //DarkBlue
    public GameObject Gear7; //RedBlue
    public GameObject Gear8; //Orange
    public GameObject Gear9; //Iron Gray
    public GameObject Gear10; // UnDefault (DE)

   static public int Switch;
	// Use this for initialization
	void Start () {
        Switch = PlayerPrefs.GetInt("Gear_Switch");
    }
	
	// Update is called once per frame
	void Update () {                     // 코루틴 화 가능!!!!!!!!!!!!!!!!!!!!!!!!!!!
        if (Switch == 1)
        {
            Gear1.SetActive(true);
        }
        else
        {
            Gear1.SetActive(false);
        }

        if (Switch == 2)
        {
            Gear2.SetActive(true);
        }
        else
        {
            Gear2.SetActive(false);
        }

        if (Switch == 3)
        {
            Gear3.SetActive(true);
        }
        else
        {
            Gear3.SetActive(false);
        }

        if (Switch == 4)
        {
            Gear4.SetActive(true);
        }
        else
        {
            Gear4.SetActive(false);
        }

        if (Switch == 5)
        {
            Gear5.SetActive(true);
        }
        else
        {
            Gear5.SetActive(false);
        }

        if (Switch == 6)
        {
            Gear6.SetActive(true);
        }
        else
        {
            Gear6.SetActive(false);
        }

        if (Switch == 7)
        {
            Gear7.SetActive(true);
        }
        else
        {
            Gear7.SetActive(false);
        }

        if (Switch == 8)
        {
            Gear8.SetActive(true);
        }
        else
        {
            Gear8.SetActive(false);
        }

        if (Switch == 9)
        {
            Gear9.SetActive(true);
        }
        else
        {
            Gear9.SetActive(false);
        }

        if (Switch == 10)
        {
            Gear10.SetActive(true);
        }
        else
        {
            Gear10.SetActive(false);
        }

        if(Combo.IsMissionPlaying)
        {
            MissionPlaying();
        }
    }

    public void MissionPlaying()
    {
        if(Combo.IsMissionPlaying)
        {
            if(Mission.Mission_Switcher == 7)
            {
                Switch = 1; //7번 미션 (as same as) : 노트 색과 기어 색이 동일한 하얀색이 됩니다.
            }
        }
    }
}
