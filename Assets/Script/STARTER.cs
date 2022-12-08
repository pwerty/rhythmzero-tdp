using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class STARTER : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (GameObject.Find("music").GetComponent<AudioSource>().isPlaying == false)
        {
            if (this.gameObject.name == "TutorialStarter")
            {
                SceneManager.LoadScene("RZ_tutorial");
            }
            else if (this.gameObject.name == "FreeStarter")
            {
                SceneManager.LoadScene("Free_select");
            }
            else if (this.gameObject.name == "MissionStarter")
            {
                SceneManager.LoadScene("Mission_mode");
            }
            else if (this.gameObject.name == "NetworkStarter")
            {
                SceneManager.LoadScene("NETWORK");
            }
            // 옵션은 arrive 영상 없이 바로 시작함
        }
            
	}
}
