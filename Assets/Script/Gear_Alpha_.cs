using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear_Alpha_ : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        
	}
}
