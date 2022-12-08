using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Esc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (this.gameObject.name == "esc_ingame")
            {
                if(ThisSceneIsActive.IsMission)
                {
                    SceneManager.LoadScene("Mission_mode");
                }
                else
                {
                    SceneManager.LoadScene("Free_select");
                }
                
            }
            else if (this.gameObject.name == "esc_select_1")
            {
                SceneManager.LoadScene("title");
            }
            else if (this.gameObject.name == "esc_select_2")
            {
                SceneManager.LoadScene("modeselect");
            }
            else
            {
                Application.Quit();
            }
        }
	}
}
