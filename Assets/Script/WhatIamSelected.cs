using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatIamSelected : MonoBehaviour {

    public Sprite ThisImage;
    public string ThisImage_name;
    public GameObject Clear;

    // 클리어, 미클리어 스크립트입니다. Clear의 경우 Blue. Not-Clear의 경우 Red로 Outline 색이 잡힙니다.
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ThisImage = GetComponent<Image>().sprite; //Sprite는 Inspector - Image의 SourceImage를 가리킨다. 1221
        ThisImage_name = ThisImage.name;

        if(ThisImage_name == "mission001")
        {
            if(PlayerPrefs.GetInt("IsClear1stMission_dev") == 2)
            {
                GetComponent<Outline>().effectColor = Color.blue;
                Clear.SetActive(true);
            }
            else
            {
                GetComponent<Outline>().effectColor = Color.red;
                Clear.SetActive(false);
            }
            
        }
        else  if(ThisImage_name == "mission007")
        {
            if (PlayerPrefs.GetInt("IsClear1stMission_dev") == 2)
            {
                GetComponent<Outline>().effectColor = Color.blue;
                Clear.SetActive(true);
            }
            else
            {
                GetComponent<Outline>().effectColor = Color.red;
                Clear.SetActive(false);
            }
        }
        else
        {
            GetComponent<Outline>().effectColor = Color.red;
            Clear.SetActive(false);
        }
        

    }
}
