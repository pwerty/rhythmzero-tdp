using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock_PerLevel : MonoBehaviour {


    // 레벨업 메시지에 같이 등장하는 해금 내용 안내 메시지 스크립트
	// Use this for initialization
	void Start () {

	}
	// 한번만 나오게 어떻게 만들지 흠
	// Update is called once per frame
	void Update () {                        // 높은 순으로 정렬 하는게 나을 듯 //중복으로 나오는거 방지하는게 잘 안됨
        if (PlayerPrefs.GetInt("Player_Level") >= 20)// && PlayerPrefs.HasKey("Is_Lv20_Unlocked") == false)
        {
            GetComponent<Text>().text = "새로운 미션 : rnasterpiece";
            PlayerPrefs.SetInt("Is_Lv20_Unlocked", 1);
        }
        else if (PlayerPrefs.GetInt("Player_Level") >= 10)// && PlayerPrefs.HasKey("Is_Lv10_Unlocked") == false)
        {
            GetComponent<Text>().text = "새로운 캐릭터 : Kang Hee";
            PlayerPrefs.SetInt("Is_Lv10_Unlocked", 1);
        }
		else if(PlayerPrefs.GetInt("Player_Level") >= 3)// && PlayerPrefs.HasKey("Is_Lv3_Unlocked") == false)
        {
            GetComponent<Text>().text = "새로운 미션 : Bon Appletit";
            PlayerPrefs.SetInt("Is_Lv3_Unlocked", 1);
        }
        else
        {
            GetComponent<Text>().text = "잠금 해제 된 요소가 없습니다.";
        }

        print(PlayerPrefs.GetInt("Player_Level"));
	}
}
