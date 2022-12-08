using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Signal : MonoBehaviour {
    public GameObject Press_Gradient;
    public Color colorStart = Color.black;
    public Color colorEnd = Color.white;
    public float duration;
    public Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
 
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);

    }
}
