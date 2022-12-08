using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading_ : MonoBehaviour {

    public Text MaxCombo_Count;
    public Text A_Count;
    public Text Fail_Count;
    public Text Boost_Count;
    public Text Score_Count;

	// Use this for initialization
	void Start () {
        MaxCombo_Count.text = Ingame_Mission.MaxCombo_count_value.ToString();
        A_Count.text = Ingame_Mission.A_count_value.ToString();
        Fail_Count.text = Ingame_Mission.Fail_count_value.ToString();
        Boost_Count.text = Ingame_Mission.Boost_count_value.ToString();
        Score_Count.text = Combo.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if(Ingame_Mission.Is_Clear1 && Ingame_Mission.Is_Clear2 && Ingame_Mission.Is_Clear3 && Ingame_Mission.Is_Clear4)
        {
            MissionManager.CanPlayNext = true;
        }
	}
}
