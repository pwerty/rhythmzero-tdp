using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement_dev : MonoBehaviour {
    //업적 스크립트.. 능력이 된다면 여러 업적을 한 스크립트 해결 해볼텐데

    int Achievement1_Required_Value;
    public Text Achievement1_Percent;


	// Use this for initialization
	void Start () {
        //1번 업적 달성 조건


        if (gameObject.name == "achievement1")
        {
            Achievement1();
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public void Achievement1()
    {
        // 5레벨 미만 패턴의 총 합 점수가 6만점 이상
        // Deborah NM, Frozen Eyes NM, HousePlan NM, R.F.C NM 해당 - 1218 기준
        Achievement1_Required_Value = PlayerPrefs.GetInt("deborah_MAXscore_NM") + PlayerPrefs.GetInt("frozeneyes_MAXscore_NM") + PlayerPrefs.GetInt("houseplan_MAXscore_NM") + PlayerPrefs.GetInt("rfc_MAXscore_NM");

        if (Achievement1_Required_Value >= 60000)
        {
            Achievement1_Percent.text = "100%";
            this.GetComponent<Slider>().value = 1;
            Achievement1_Sender();

        }
        else
        {
           Achievement1_Percent.text = (Achievement1_Required_Value / (float)60000 * 100).ToString("N0") + "%";
            this.GetComponent<Slider>().value = (Achievement1_Required_Value / (float)60000);


            print(Achievement1_Required_Value);
            print("not ready");

            
        }
    }

    static public void Achievement1_Sender()
    {
        PlayerPrefs.SetInt("Achieve1_dev_", 1);
    }
}
