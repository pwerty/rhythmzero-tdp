using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boost : MonoBehaviour {

    public GameObject Valuechecker;
    public int Boost_value = 1;
    public AudioClip BoostSound;
    public AudioSource BoostSoundPlayer;
    public GameObject BoostGuy;

    public Font Font1;
    public Font Font2;
    public Font Font3;
    public Font Font4;
    public Font Font5;
    public Font Font6;
    public Font Font7;
    public Font Font8;
    public Font Font9;
    public Font Font10;

    public int BoostSkin;

    // Use this for initialization
    void Start () {
       BoostSoundPlayer = gameObject.AddComponent<AudioSource>();
        BoostSoundPlayer.clip = BoostSound;
        BoostSoundPlayer.volume = 0.3f;

        BoostSkin = PlayerPrefs.GetInt("BoostFont_Switch");

        if (SceneManager.GetActiveScene().name == "RZ_tutorial")
        {
            BoostSkin = 1;
        }

        if (BoostSkin == 1)
        {
            BoostGuy.GetComponent<Text>().font = Font1;
        }
        else if (BoostSkin == 2)
        {
            BoostGuy.GetComponent<Text>().font = Font2;
        }
        else if (BoostSkin == 3)
        {
            BoostGuy.GetComponent<Text>().font = Font3;
        }
        else if (BoostSkin == 4)
        {
            BoostGuy.GetComponent<Text>().font = Font4;
        }
        else if (BoostSkin == 5)
        {
            BoostGuy.GetComponent<Text>().font = Font5;
        }
        else if (BoostSkin == 6)
        {
            BoostGuy.GetComponent<Text>().font = Font6;
        }
        else if (BoostSkin == 7)
        {
            BoostGuy.GetComponent<Text>().font = Font7;
        }
        else if (BoostSkin == 8)
        {
            BoostGuy.GetComponent<Text>().font = Font8;
        }
        else if (BoostSkin == 9)
        {
            BoostGuy.GetComponent<Text>().font = Font9;
        }
        else if (BoostSkin == 10)
        {
            BoostGuy.GetComponent<Text>().font = Font10;
        }
    }




	// Update is called once per frame
	void Update () {

        Slider ValueCheck = Valuechecker.GetComponent<Slider>();
        if (ValueCheck.value > 0.10f)
        {

            BoostSoundPlayer.Play();
            Boost_value++;
            if(Boost_value % 10 == 0)
            {
                BoostGuy.GetComponent<Outline>().effectColor = new Color32(0xFF, 0x00, 0x00, 0x80);
                BoostGuy.GetComponent<Outline>().effectDistance = new Vector2(2, -2);
            }
            else
            {
                BoostGuy.GetComponent<Outline>().effectColor = new Color32(0x00, 0x00, 0x00, 0x80);
                BoostGuy.GetComponent<Outline>().effectDistance = new Vector2(1, -1);
            }
            BoostGuy.GetComponent<Text>().text = Boost_value + "\nB O O S T";
            BoostGuy.GetComponent<Animation>().Rewind("BoostText");
            BoostGuy.GetComponent<Animation>().Play("BoostText");
            Ingame_Network.EnemyBOOST();
            ValueCheck.value = 0f;
        }
    }
}
