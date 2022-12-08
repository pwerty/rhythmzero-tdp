using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Loader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("music").GetComponent<AudioSource>().isPlaying == false)
        {
            SceneManager.LoadScene("RZ_tutorial");
        }

       
	}
}
