using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingame_Custom_Reciever : MonoBehaviour {

    public GameObject Camera;
    public GameObject GrooveLight;

    static public bool Groove_Settings;
    int GearPosition_Switch;

    // Use this for initialization
    void Start() {
        GearPosition_Switch = PlayerPrefs.GetInt("GearPosition_Switch");


        if (SceneManager.GetActiveScene().name == "RZ_tutorial")
        {
            GearPosition_Switch = 1;
        }


        if (GearPosition_Switch == 0)
        {
            Camera.transform.position = new Vector3(10.0f, Camera.transform.position.y, Camera.transform.position.z);
        }
        else if (GearPosition_Switch == 1)
        {
            Camera.transform.position = new Vector3(0f, Camera.transform.position.y, Camera.transform.position.z);
        }
        else if (GearPosition_Switch == 2)
        {
            Camera.transform.position = new Vector3(-10.0f, Camera.transform.position.y, Camera.transform.position.z);
        }

        /* if(Groove_Settings)
         {
             GrooveLight.SetActive(true);
         }
         else
         {
             GrooveLight.SetActive(false);
         }*/
    }

    // Update is called once per frame
    void Update () {
		
	}
}
