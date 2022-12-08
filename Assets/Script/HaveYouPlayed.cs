using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveYouPlayed : MonoBehaviour
{
    public GameObject Information_Newbie;

    // 만약 리듬제로를 처음으로 실행하는 컴퓨터라면, 초기 설정을 진행하게 되는 스크립트입니다.
    // 돈 기본값, 경험치 기본 값

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.HasKey("line1") == false) // 1번 라인 키가 있는지만 확인
        {
            Debug.Log("이 컴퓨터는 리듬제로를 처음 실행합니다. 초기 키 설정을 진행합니다.");
            PlayerPrefs.SetString("line1", "Alpha1");
            PlayerPrefs.SetString("line2", "Alpha2");
            PlayerPrefs.SetString("line3", "Alpha3");
            PlayerPrefs.SetString("line4", "Alpha4");
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Note_Switch") == false) // 노트
        {
            Debug.Log("이 컴퓨터는 리듬제로를 처음 실행합니다. 노트 기본 설정 진행중..");
            PlayerPrefs.SetInt("Note_Switch", 0);
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("ComboFont_Switch") == false) //콤보 폰트
        {
            Debug.Log("이 컴퓨터는 리듬제로를 처음 실행합니다. 콤보 폰트 기본 설정 진행중..");
            PlayerPrefs.SetInt("ComboFont_Switch", 1);
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("BoostFont_Switch") == false) //부스트 폰트
        {
            Debug.Log("이 컴퓨터는 리듬제로를 처음 실행합니다. 부스트 폰트 기본 설정 진행중..");
            PlayerPrefs.SetInt("BoostFont_Switch", 1);
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Gear_Switch") == false) //기어 스킨
        {
            Debug.Log("이 컴퓨터는 리듬제로를 처음 실행합니다. 기어 스킨 기본 설정 진행중..");
            PlayerPrefs.SetInt("Gear_Switch", 1);
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Player_Exp") == false)
        {
            Debug.Log("경험치 기본 값");
            PlayerPrefs.SetInt("Player_Exp", 0);
            Information_Newbie.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Player_Money") == false)
        {
            Debug.Log("기초 자금");
            PlayerPrefs.SetInt("Player_Money", 10000);
            Information_Newbie.SetActive(true);
        }
        

    }
}

