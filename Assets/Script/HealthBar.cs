using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public bool IsActiveAdmin;

    public GameObject Danger_signal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<Slider>().value == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(gameObject.GetComponent<Slider>().value < 0.1f)
        {
            Danger_signal.SetActive(true);
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "RZ_tutorial")
            {

            }
            else
            {
                Danger_signal.SetActive(false);
            }

        }

        if(IsActiveAdmin)
        {
            GetComponent<Slider>().value = 1f;
        }

        if(Combo.IsMissionPlaying)
        {
            if(Mission.Mission_Switcher == 7)
            {
                gameObject.GetComponent<Slider>().maxValue = 0.5f;
            }
        }
	}
}
