using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby_AchievementCheck : MonoBehaviour {

    int Achievement1_Required_Value;

    // Use this for initialization
    void Start () {
        Achievement1_Required_Value = PlayerPrefs.GetInt("deborah_MAXscore_NM") + PlayerPrefs.GetInt("frozeneyes_MAXscore_NM") + PlayerPrefs.GetInt("houseplan_MAXscore_NM") + PlayerPrefs.GetInt("rfc_MAXscore_NM");
    }
	
	// Update is called once per frame
	void Update () {
		if(Achievement1_Required_Value >= 60000)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
