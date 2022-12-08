using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySetting : MonoBehaviour
{
    public GameObject errorM_overlap;
    public GameObject SaveButton;

    static public bool HaveYouPlayedRZBefore = true;

    private GameObject currentKey;

   private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text Key_line1, Key_line2, Key_line3, Key_line4;

    private Color32 normal = new Color32(39, 171, 249, 255);
    private Color32 selected = new Color32(239, 116, 36, 255);
    private Color32 errors = new Color32(255, 0, 0, 255);
    // Use this for initialization

    void Start()
    {
        keys.Add("line1", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("line1", "Alpha1")));
        keys.Add("line2", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("line2", "Alpha2")));
        keys.Add("line3", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("line3", "Alpha3")));
        keys.Add("line4", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("line4", "Alpha4")));

        Key_line1.text = keys["line1"].ToString();
        Key_line2.text = keys["line2"].ToString();
        Key_line3.text = keys["line3"].ToString();
        Key_line4.text = keys["line4"].ToString();

    }

    void Update()
    {
        
        if(Key_line1.text == Key_line2.text || Key_line1.text == Key_line3.text || Key_line1.text == Key_line4.text || Key_line2.text == Key_line3.text || Key_line2.text == Key_line4.text || Key_line3.text == Key_line4.text)
        {
            errorM_overlap.SetActive(true);
            SaveButton.SetActive(false);
        }
        else
        {
            errorM_overlap.SetActive(false);
            SaveButton.SetActive(true);
        }

        if (HaveYouPlayedRZBefore == false)
        {
            Change_Default();
            HaveYouPlayedRZBefore = true;
        }
    }

    void OnGUI()
    {
        if (currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();  
                currentKey.GetComponent<Image>().color = normal;
                currentKey = null;
            } // Event가 Key를 인식하면 변경
         
        }
    }
    public void ChangeKey(GameObject Clicked)
    {
        if (currentKey != null)
        {
            currentKey.GetComponent<Image>().color = normal;
        }

        currentKey = Clicked;
        currentKey.GetComponent<Image>().color = selected;
    }
    public void SaveKeys()
    {
        foreach (var key in keys)
        {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
            PlayerPrefs.Save();
        }


        PlayerPrefs.Save();
        print(PlayerPrefs.GetString("line1"));
        print(PlayerPrefs.GetString("line2"));
        print(PlayerPrefs.GetString("line3"));
        print(PlayerPrefs.GetString("line4"));
    }

    public void Change_Default()
    {
        keys["line1"] = (KeyCode)System.Enum.Parse(typeof(KeyCode), "Alpha1");
        keys["line2"] = (KeyCode)System.Enum.Parse(typeof(KeyCode), "Alpha2");
        keys["line3"] = (KeyCode)System.Enum.Parse(typeof(KeyCode), "Alpha3");
        keys["line4"] = (KeyCode)System.Enum.Parse(typeof(KeyCode), "Alpha4");

        Key_line1.text = keys["line1"].ToString();
        Key_line2.text = keys["line2"].ToString();
        Key_line3.text = keys["line3"].ToString();
        Key_line4.text = keys["line4"].ToString();

        print(PlayerPrefs.GetString("line1"));
        print(PlayerPrefs.GetString("line2"));
        print(PlayerPrefs.GetString("line3"));
        print(PlayerPrefs.GetString("line4"));
    }
}


