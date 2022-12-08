using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile_Pic_WatchOnly : MonoBehaviour {

    public Texture Profile1; // 아직 예명입니다.
    public Texture Profile2;
    public Texture Profile3;
    public Texture Profile4;
    public Texture Profile5;
    public Texture Profile6;
    public Texture Profile7;
    public Texture Profile8;
    public Texture Profile9;
    public Texture Profile10;
    public Texture Profile11;

    public int Profile_Pic_Switch;
    // Use this for initialization
    void Start()
    {
        Profile_Pic_Switch = PlayerPrefs.GetInt("Char_Switch");

        if (Profile_Pic_Switch == 0)
        {
            this.GetComponent<RawImage>().texture = Profile1;
        }

        if (Profile_Pic_Switch == 1)
        {
            this.GetComponent<RawImage>().texture = Profile2;
        }

        if (Profile_Pic_Switch == 2)
        {
            this.GetComponent<RawImage>().texture = Profile3;
        }

        if (Profile_Pic_Switch == 3)
        {
            this.GetComponent<RawImage>().texture = Profile4;
        }

        if (Profile_Pic_Switch == 4)
        {
            this.GetComponent<RawImage>().texture = Profile5;
        }

        if (Profile_Pic_Switch == 5)
        {
            this.GetComponent<RawImage>().texture = Profile6;
        }

        if (Profile_Pic_Switch == 6)
        {
            this.GetComponent<RawImage>().texture = Profile7;
        }

        if (Profile_Pic_Switch == 7)
        {
            this.GetComponent<RawImage>().texture = Profile8;
        }

        if (Profile_Pic_Switch == 8)
        {
            this.GetComponent<RawImage>().texture = Profile9;
        }

        if (Profile_Pic_Switch == 9)
        {
            this.GetComponent<RawImage>().texture = Profile10;
        }

        if (Profile_Pic_Switch == 10)
        {
            this.GetComponent<RawImage>().texture = Profile11;
        }

    }

  

    // Update is called once per frame
    void Update () {
		
	}
}
