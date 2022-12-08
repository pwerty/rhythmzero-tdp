using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsShouldPlayAnimation_LevelUP : MonoBehaviour {

    public Text LevelUP_Animation;
    public Text HowManyUP;
    Animator Animator;
    int Prev_Level;
    int Now_Level;
    int calc_value;


    bool Animation;

	// Use this for initialization
	void Start () {

      
        Animator = LevelUP_Animation.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Prev_Level = Player_Level.i_static;
        Now_Level = PlayerPrefs.GetInt("Player_Level");
        calc_value = Now_Level - Prev_Level;

        print(Prev_Level);
        print(Now_Level);
        print(calc_value);

        if (Now_Level > Prev_Level && !Animation)
        {
            LvUP();
            Animation = true;
        }
        // if(LevelUP_Animation.GetComponent<Animator>().)

        if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1.0f)
        {
            LevelUP_Animation.gameObject.SetActive(false);

        }

    }

    public void LvUP()
    {
        LevelUP_Animation.gameObject.SetActive(true);
        LevelUP_Animation.text = "LEVEL UP!";
        HowManyUP.text = "LEVEL +" + calc_value;
    }
}
