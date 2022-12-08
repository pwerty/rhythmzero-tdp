using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThisSceneIsActive : MonoBehaviour {

    static public bool IsMission = false;

	// Use this for initialization
	void Start () {
       if (SceneManager.GetActiveScene().name == "Free_select")
        {
            IsMission = false;
        }
       else
        {
            IsMission = true;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
