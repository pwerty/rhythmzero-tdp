using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Font_name : MonoBehaviour {

    public GameObject ThisFontName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = ThisFontName.GetComponent<Text>().font.ToString();
	}
}
