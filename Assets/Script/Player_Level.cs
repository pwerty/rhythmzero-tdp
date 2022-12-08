using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Level : MonoBehaviour {

    public int _exp = 0;
    int[] ExpArray = new int[100];
    int i = 0;
    static public int i_static;
    bool Done = true;

    //레벨 로드 스크립트

    // Use this for initialization
    void Start () {
        List<Dictionary<string, object>> data = CSVReader.Read("exp");

        /*for (var i = 0; i < data.Count; i++)
        {
            Debug.Log("index " + (i).ToString() + " : " + data[i]["EXP"] + " " + data[i]["LEVEL"]); //대소문자 구별 철저하게 하셈 ㅜㅜ
        }*/

        i_static = PlayerPrefs.GetInt("Player_Level");

        for (var a = 0; a < data.Count; a++)
        {
            ExpArray[a] = (int)data[a]["EXP"];
        }

        while(Done)
        {
            
            if(PlayerPrefs.GetInt("Player_Exp") > ExpArray[i])
            {
                i++;
            }

            else
            {
                
                Done = false;
                this.GetComponent<Text>().text = "LV. " + i;
            }
        }
        print(PlayerPrefs.GetInt("Player_Exp"));
        if(PlayerPrefs.GetInt("Player_Level") != i)
        {
            
            // 애니메이션 재생. 레벨업입니다 bro~
            PlayerPrefs.SetInt("Player_Level", i);
           
        }
        else
        {
            print("Player_Level 세이브 데이터와 i가 같음");
        }
        
        
    }
	
	// Update is called once per frame
	void Update () {

        }
	}

