using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour {

    public GameObject buy_button;
    public Text Switched;
   static public bool IsEquiped = true;
    public Dictionary<string, int> equip = new Dictionary<string, int>();

    /*
    public GameObject Character_Group_Button;
    public GameObject GearSkin_Group_Button;
    public GameObject NoteSkin_Group_Button;
    public GameObject ComboFont_Group_Button;
    public GameObject BoostFont_Group_Button;
    public GameObject ProfilePlate_Group_Button;
    public GameObject ProfileComment_Group_Button;
    public GameObject JudgeFont_Group_Button;
    
    public Button Character_Group_Button;
    public Button GearSkin_Group_Button;
    public Button NoteSkin_Group_Button;
    public Button ComboFont_Group_Button;
    public Button BoostFont_Group_Button;
    public Button ProfilePlate_Group_Button;
    public Button ProfileComment_Group_Button;
    public Button JudgeFont_Group_Button;
    */

    public Text Character_Group_Text;
    public Text GearSkin_Group_Text;
    public Text NoteSkin_Group_Text;
    public Text ComboFont_Group_Text;
    public Text BoostFont_Group_Text;
    public Text ProfilePlate_Group_Text;
    public Text ProfileComment_Group_Text;
    public Text JudgeFont_Group_Text;
    public Text ETC_Group_Text;

    public GameObject Character_Group_Scroll;
    public GameObject GearSkin_Group_Scroll;
    public GameObject NoteSkin_Group_Scroll;
    public GameObject ComboFont_Group_Scroll;
    public GameObject BoostFont_Group_Scroll;
    public GameObject ProfilePlate_Group_Scroll;
    public GameObject ProfileComment_Group_Scroll;
    public GameObject JudgeFont_Group_Scroll;
    public GameObject ETC_Group_Scroll;

    public Color selected_color = Color.blue;
    public Color32 unselected_color = Color.red;
    public ColorBlock Selected;
    public ColorBlock UnSelected;

    public int group_display_switch = 1;

    // Use this for initialization
    void Start () {

        Selected.normalColor = selected_color;
        UnSelected.normalColor = unselected_color;
	}
	
	// Update is called once per frame
	void Update () {
       
        if (group_display_switch == 1)
        {
            Character_Group_Text.color = Color.red;
            Character_Group_Scroll.SetActive(true);

        }
        else
        {
            Character_Group_Text.color = Color.black;
            Character_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 2)
        {
            GearSkin_Group_Text.color = Color.red;
            GearSkin_Group_Scroll.SetActive(true);
        }
        else
        {
            GearSkin_Group_Text.color = Color.black;
            GearSkin_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 3)
        {
            NoteSkin_Group_Text.color = Color.red;
            NoteSkin_Group_Scroll.SetActive(true);
        }
        else
        {
            NoteSkin_Group_Text.color = Color.black;
            NoteSkin_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 4)
        {
            ComboFont_Group_Text.color = Color.red;
            ComboFont_Group_Scroll.SetActive(true);
        }
        else
        {
            ComboFont_Group_Text.color = Color.black;
            ComboFont_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 5)
        {
            BoostFont_Group_Text.color = Color.red;
            BoostFont_Group_Scroll.SetActive(true);
        }
        else
        {
            BoostFont_Group_Text.color = Color.black;
            BoostFont_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 6)
        {
            ProfilePlate_Group_Text.color = Color.red;
            ProfilePlate_Group_Scroll.SetActive(true);
        }
        else
        {
            ProfilePlate_Group_Text.color = Color.black;
            ProfilePlate_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 7)
        {
            ProfileComment_Group_Text.color = Color.red;
            ProfileComment_Group_Scroll.SetActive(true);
        }
        else
        {
            ProfileComment_Group_Text.color = Color.black;
            ProfileComment_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 8)
        {
            JudgeFont_Group_Text.color = Color.red;
            JudgeFont_Group_Scroll.SetActive(true);
        }
        else
        {
            JudgeFont_Group_Text.color = Color.black;
            JudgeFont_Group_Scroll.SetActive(false);
        }

        if (group_display_switch == 9)
        {
            ETC_Group_Text.color = Color.red;
            ETC_Group_Scroll.SetActive(true);
        }
        else
        {
            ETC_Group_Text.color = Color.black;
            ETC_Group_Scroll.SetActive(false);
        }
	}

    public void Switch()
    {
        if(IsEquiped == true)
        {
            IsEquiped = false;
            Switched.text = "false";
        }
        else
        {
            IsEquiped = true;
            Switched.text = "true";
        }
    }

    public void ChangeToCharacter()
    {
        group_display_switch = 1;
    }

    public void ChangeToGearSkin()
    {
        group_display_switch = 2;
    }

    public void ChangeToNoteSkin()
    {
        group_display_switch = 3;
    }

    public void ChangeToComboFont()
    {
        group_display_switch = 4;
    }
    
    public void ChangeToBoostFont()
    {
        group_display_switch = 5;
    }

    public void ChangeToProfilePlate()
    {
        group_display_switch = 6;
    }

    public void ChangeToProfileComment()
    {
        group_display_switch = 7;
    }

    public void ChangeToJudgeFont()
    {
        group_display_switch = 8;
    }

    public void ChangeToETC()
    {
        group_display_switch = 9;
    }
}
