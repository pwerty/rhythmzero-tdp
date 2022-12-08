using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gear_Admin : MonoBehaviour {

    public Text Gear1;
    public Text Gear2;
    public Text Gear3;
    public Text Gear4;
    public Text Gear5;
    public Text Gear6;
    public Text Gear7;
    public Text Gear8;
    public Text Gear9;
    public Text Gear10;

    static public int Gear_Switch;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.HasKey("Gear_Switch"))
        {
            Gear_Switch = PlayerPrefs.GetInt("Gear_Switch");
        }
        else
        {
            PlayerPrefs.SetInt("Gear_Switch", 1);
            Gear_Switch = PlayerPrefs.GetInt("Gear_Switch");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Gear_Switch == 1)
        {
            Gear1.text = "착용중";
        }
        else
        {
            Gear1.text = "Default";
        }

        if (Gear_Switch == 2)
        {
            Gear2.text = "착용중";
        }
        else
        {
            Gear2.text = "WhiteRed";
        }

        if (Gear_Switch == 3)
        {
            Gear3.text = "착용중";
        }
        else
        {
            Gear3.text = "JetStream";
        }

        if (Gear_Switch == 4)
        {
            Gear4.text = "착용중";
        }
        else
        {
            Gear4.text = "Mint";
        }

        if (Gear_Switch == 5)
        {
            Gear5.text = "착용중";
        }
        else
        {
            Gear5.text = "Yellow";
        }

        if (Gear_Switch == 6)
        {
            Gear6.text = "착용중";
        }
        else
        {
            Gear6.text = "DarkBlue";
        }

        if (Gear_Switch == 7)
        {
            Gear7.text = "착용중";
        }
        else
        {
            Gear7.text = "RedBlue";
        }

        if (Gear_Switch == 8)
        {
            Gear8.text = "착용중";
        }
        else
        {
            Gear8.text = "Orange";
        }

        if (Gear_Switch == 9)
        {
            Gear9.text = "착용중";
        }
        else
        {
            Gear9.text = "Iron Gray";
        }

        if (Gear_Switch == 10)
        {
            Gear10.text = "착용중";
        }
        else
        {
            Gear10.text = "Negative Default";
        }
    }

    public void SwitchToGearSkin1()
    {
        Gear_Switch = 1;
        PlayerPrefs.SetInt("Gear_Switch", 1);
    }

    public void SwitchToGearSkin2()
    {
        Gear_Switch = 2;
        PlayerPrefs.SetInt("Gear_Switch", 2);
    }

    public void SwitchToGearSkin3()
    {
        Gear_Switch = 3;
        PlayerPrefs.SetInt("Gear_Switch", 3);
    }

    public void SwitchToGearSkin4()
    {
        Gear_Switch = 4;
        PlayerPrefs.SetInt("Gear_Switch", 4);
    }

    public void SwitchToGearSkin5()
    {
        Gear_Switch = 5;
        PlayerPrefs.SetInt("Gear_Switch", 5);
    }

    public void SwitchToGearSkin6()
    {
        Gear_Switch = 6;
        PlayerPrefs.SetInt("Gear_Switch", 6);
    }

    public void SwitchToGearSkin7()
    {
        Gear_Switch = 7;
        PlayerPrefs.SetInt("Gear_Switch", 7);
    }

    public void SwitchToGearSkin8()
    {
        Gear_Switch = 8;
        PlayerPrefs.SetInt("Gear_Switch", 8);
    }

    public void SwitchToGearSkin9()
    {
        Gear_Switch = 9;
        PlayerPrefs.SetInt("Gear_Switch", 9);
    }

    public void SwitchToGearSkin10()
    {
        Gear_Switch = 10;
        PlayerPrefs.SetInt("Gear_Switch", 10);
    }
}
