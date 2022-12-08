using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Another_Disable : MonoBehaviour {
   static public GameObject temp;
   static public void Click()
    {
        if(temp != false)
        {
        temp.SetActive(false);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        temp = GameObject.FindGameObjectWithTag("selector");
	}
}
