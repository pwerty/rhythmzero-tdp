using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {

   public int BeatCoin;

	// Use this for initialization
	void Start () {
        //  PlayerPrefs.SetInt("BeatCoin", 10000);
        //BeatCoin = PlayerPrefs.GetInt("BeatCoin");
        BeatCoin = PlayerPrefs.GetInt("Player_Money");
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = BeatCoin.ToString();

        PlayerPrefs.SetInt("BeatCoin", BeatCoin);
	}
}
