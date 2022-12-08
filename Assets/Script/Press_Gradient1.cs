using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Gradient1 : MonoBehaviour {
    public GameObject key_gradient;

    public KeyCode Line1Key;
    public KeyCode Line2Key;
    public KeyCode Line3Key;
    public KeyCode Line4Key;

    public KeyCode Line_Plus;

    // Use this for initialization
    void Start () {


     }

    // Update is called once per frame

        // 플레이어 입력 시 각 라인이 반응 하는 스크립트입니다.
    void Update()
    {
            string line1 = PlayerPrefs.GetString("line1");
            string line2 = PlayerPrefs.GetString("line2");
            string line3 = PlayerPrefs.GetString("line3");
            string line4 = PlayerPrefs.GetString("line4");

        Line1Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), line1);
       // Line1Key = KeyCode.LeftShift;
       // Line_Plus = KeyCode.D;
         Line2Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), line2);
        Line3Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), line3);
        Line4Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), line4);

        key_gradient.GetComponent<Renderer>().enabled = false;
        if(this.name == "Gradient_line1")
        {

            if (Input.GetKey(Line1Key))
            {
                key_gradient.GetComponent<Renderer>().enabled = true;


            }
            else
            {
                key_gradient.GetComponent<Renderer>().enabled = false;
            }
        }
           else if (this.name == "Gradient_line2")
        {
            if (Input.GetKey(Line2Key))
            {
                key_gradient.GetComponent<Renderer>().enabled = true;


            }
            else
            {
                key_gradient.GetComponent<Renderer>().enabled = false;
            }
        }
               else if (this.name == "Gradient_line3")
        {
            if (Input.GetKey(Line3Key))
            {
                key_gradient.GetComponent<Renderer>().enabled = true;


            }
            else
            {
                key_gradient.GetComponent<Renderer>().enabled = false;
            }
        }
                   else if (this.name == "Gradient_line4")
        {
            if (Input.GetKey(Line4Key))
            {
                key_gradient.GetComponent<Renderer>().enabled = true;


            }
            else
            {
                key_gradient.GetComponent<Renderer>().enabled = false;
            }
        }

        else
        {
            key_gradient.GetComponent<Renderer>().enabled = false;
        }

    }
}
