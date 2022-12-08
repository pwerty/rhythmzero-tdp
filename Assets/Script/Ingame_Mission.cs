using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ingame_Mission : MonoBehaviour {
    // 조건부를 달성하면 카운트하는 텍스트에 초록불이 들어오는 스크립트

    public GameObject A_count;
    public GameObject MaxCombo_count;
    public GameObject Fail_count;
    public GameObject Boost_count;

    public GameObject Now_Stage;

    static public int A_count_cache;
    static public int MaxCombo_count_cache;
    static public int Fail_count_cache;
    static public int Boost_count_cache;

    static public int A_count_value = 0;
    static public int MaxCombo_count_value = 0;
    static public int Fail_count_value = 0;
    static public int Boost_count_value = 0;

    static public bool Is_Clear1;
    static public bool Is_Clear2;
    static public bool Is_Clear3;
    static public bool Is_Clear4;


    // Use this for initialization
    private void Awake()
    {
        Is_Clear1 = false;
        Is_Clear2 = false;
        Is_Clear3 = false;
        Is_Clear4 = false;
    }

    void Start () {
		if(Combo.IsMissionPlaying == false)
        {
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {

 
        

        if(Mission.Mission_Switcher  == 1) //1번 미션 - 뽕애플티
        {

            if (MissionManager.StageCount + 1 == MissionManager.Mission1_Stage_Count)
            {
                Now_Stage.GetComponent<Text>().text = "FINAL STAGE";
            }
            else
            {
                Now_Stage.GetComponent<Text>().text = "STAGE " + MissionManager.StageCount.ToString();
            }
            /* 1번 미션 클리어 조건
             * A_Count 10개 이상
             * MaxCombo 5개 이상
             * Fail 제한 없음
             * Boost 3x 이상
             */
            if (int.Parse(A_count.GetComponent<Text>().text) >= 10)
            {
                A_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear1 = true;
            }
             else
            {
                A_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear1 = false;
            }

             if(int.Parse(MaxCombo_count.GetComponent<Text>().text) >= 5)
            {
                MaxCombo_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear2 = true;
            }
             else
            {
                MaxCombo_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear2 = false;
            }

            if(int.Parse(Fail_count.GetComponent<Text>().text) == 0)
            {
                Fail_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear3 = true;
            }
            else
            {
                Fail_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear3 = true;
            }

            if(int.Parse(Boost_count.GetComponent<Text>().text) >= 3)
            {
                Boost_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear4 = true;
            }
            else
            {
                Boost_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear4 = false;
            }
        }
        else if(Mission.Mission_Switcher  == 2)
        {

        }
        /* 3,4,5,6 스킵 */
        else if(Mission.Mission_Switcher == 7)
        {
            /* 7번 미션 클리어 조건
             * A_Count 30개 이상
             * MaxCombo 30 이상
             * Fail 50개 이하
             * Boost 5x 이상
             */
            if (MissionManager.StageCount + 1 == MissionManager.Mission7_Stage_Count)
            {
                Now_Stage.GetComponent<Text>().text = "FINAL STAGE";
            }
            else
            {
                Now_Stage.GetComponent<Text>().text = "STAGE " + MissionManager.StageCount.ToString();
            }


            if (int.Parse(A_count.GetComponent<Text>().text) >= 30)
            {
                A_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear1 = true;
            }
            else
            {
                A_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear1 = false;
            }

            if (int.Parse(MaxCombo_count.GetComponent<Text>().text) >= 30)
            {
                MaxCombo_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear2 = true;
            }
            else
            {
                MaxCombo_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear2 = false;
            }

            if (int.Parse(Fail_count.GetComponent<Text>().text) <= 50)
            {
                Fail_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear3 = true;
            }
            else
            {
                Fail_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear3 = true;
            }

            if (int.Parse(Boost_count.GetComponent<Text>().text) >= 5)
            {
                Boost_count.GetComponent<Outline>().effectColor = Color.green;
                Is_Clear4 = true;
            }
            else
            {
                Boost_count.GetComponent<Outline>().effectColor = Color.red;
                Is_Clear4 = false;
            }

        }
        A_count_value = int.Parse(A_count.GetComponent<Text>().text);
        MaxCombo_count_value = int.Parse(MaxCombo_count.GetComponent<Text>().text);
        Fail_count_value = int.Parse(Fail_count.GetComponent<Text>().text);
        Boost_count_value = int.Parse(Boost_count.GetComponent<Text>().text);

	}
}
