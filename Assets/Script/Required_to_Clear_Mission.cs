using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Required_to_Clear_Mission : MonoBehaviour {

    public Text MAX_COMBO;
    public Text A_Count;
    public Text Score;
    public Text Fail_Count;
    public Text Boost_Count;

    public int Switcher_To_Display;

    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        Switcher_To_Display = Mission.Mission_Switcher;

        if (Switcher_To_Display == 1)
        {
            MAX_COMBO.text = "M_COMBO\n>= 5";
            A_Count.text = "'A'COUNT\n>= 10";
            Score.text = "SCORE\n>= 0";
            Fail_Count.text = "FAIL\n>= 0";
            Boost_Count.text = "BOOST\n>= 3";
        }
        else if (Switcher_To_Display == 7)
        {
            MAX_COMBO.text = "M_COMBO\n>= 30";
            A_Count.text = "'A'COUNT\n>= 30";
            Score.text = "SCORE\n>= 0";
            Fail_Count.text = "FAIL\n<= 50";
            Boost_Count.text = "BOOST\n>= 5";
        }
        else
        {
            MAX_COMBO.text = "NO!";
            A_Count.text = "NO!";
            Score.text = "NO!";
            Fail_Count.text = "NO!";
            Boost_Count.text = "NO!";
        }

	}
}
