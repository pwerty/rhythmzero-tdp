using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plate_Color_WatchOnly : MonoBehaviour {

    public Color32 Panel1_Color;
    public Color32 Panel2_Color;
    public Color32 Panel3_Color;
    public Color32 Panel4_Color;
    public Color32 Panel5_Color;
    public Color32 Panel6_Color;
    public Color32 Panel7_Color;
    public Color32 Panel8_Color;
    public Color32 Panel9_Color;
    public Color32 Panel10_Color;

    public int Color_Switch = 0;

    // Use this for initialization
        void Start()
        {
        Color_Switch = PlayerPrefs.GetInt("Color_Switch");

        Panel1_Color = new Color32(0xFF, 0xFF, 0xFF, 0x63);
        Panel2_Color = new Color32(0xFF, 0x00, 0x00, 0x63);
        Panel3_Color = new Color32(0xC3, 0x00, 0xC3, 0x63);
        Panel4_Color = new Color32(0x00, 0xFF, 0xBF, 0x63);
        Panel5_Color = new Color32(0x5C, 0x56, 0xFF, 0x63);
        Panel6_Color = new Color32(0xFF, 0xB9, 0x01, 0x63);
        Panel7_Color = new Color32(0xFF, 0xF7, 0x00, 0x63);
        Panel8_Color = new Color32(0x3D, 0xFF, 0x0D, 0x63);
        Panel9_Color = new Color32(0x0A, 0x00, 0x85, 0x63);
        Panel10_Color = new Color32(0x00, 0x00, 0x00, 0x63);
        }
	
	// Update is called once per frame
	void Update () {
        if (Color_Switch == 0)
        {
            this.GetComponent<Image>().color = Panel1_Color;
        }

        if (Color_Switch == 1)
        {
            this.GetComponent<Image>().color = Panel2_Color;
        }

        if (Color_Switch == 2)
        {
            this.GetComponent<Image>().color = Panel3_Color;
        }

        if (Color_Switch == 3)
        {
            this.GetComponent<Image>().color = Panel4_Color;
        }

        if (Color_Switch == 4)
        {
            this.GetComponent<Image>().color = Panel5_Color;
        }

        if (Color_Switch == 5)
        {
            this.GetComponent<Image>().color = Panel6_Color;
        }

        if (Color_Switch == 6)
        {
            this.GetComponent<Image>().color = Panel7_Color;
        }

        if (Color_Switch == 7)
        {
            this.GetComponent<Image>().color = Panel8_Color;
        }

        if (Color_Switch == 8)
        {
            this.GetComponent<Image>().color = Panel9_Color;
        }

        if (Color_Switch == 9)
        {
            this.GetComponent<Image>().color = Panel10_Color;
        }
    }
}
