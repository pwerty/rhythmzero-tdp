using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judge_line1 : MonoBehaviour
{

    public Vector3 effect_rotation;
    public Text combo;

    public KeyCode Line1Key;
    public KeyCode Line_Plus;


    public GameObject lightEffect_1line;
  //  public GameObject lightEffect_2line;
   // public GameObject lightEffect_3line;
    //public GameObject lightEffect_4line;

    public GameObject lightEffects_1line;
  //  public GameObject lightEffects_2line;
   // public GameObject lightEffects_3line;
   // public GameObject lightEffects_4line;

    private GameObject NoteTemp;
    private int count;

    float Judge_1_value = 6f; //1 + 5  + 1f;  //판정 맨 위 //E_Judge start
    float Judge_2_value = 5.5f; //0.9f + 1f; //E_Judge end // D_Judge start
    float Judge_3_value = 4.5f;// 0.8f +1;  //D_Judee end // C_Judge start
    float Judge_4_value = 3.0f;// 0.6f +1;  //C_Judge end // B_Judge start
    float Judge_5_value = 1.75f; // 0.65f +1;  //B_Judge end // A_Judge start //여기까지 상단


    public GameObject JudgeA_Effect;
    public GameObject JudgeB_Effect;
    public GameObject JudgeC_Effect;
    public GameObject JudgeD_Effect;
    public GameObject JudgeE_Effect;
    public GameObject JudgeF_Effect;
    public GameObject ScoreGuy;

    public Slider Boost;

   
    /*
    void OnTriggerStay(Collider other)
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit Notes;

        /*
        if (other.name == "note_line1(Clone)")
        {
           // Debug.Log("1번 노트가 지나갔다 bro..");
            if (Input.GetKeyDown("d"))
            {

                if (Physics.Raycast(transform.position, transform.forward, out Notes, 2.0f) && Physics.Raycast(transform.position, transform.forward, out Notes, Judge_1_value))
                {
 
                    print(Notes);
                    if (Notes.collider.name == other.name)
                    {
                        NoteTemp = other.gameObject;
                        lightEffects = (GameObject)Instantiate(lightEffect_1line, other.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        NoteTemp.gameObject.SetActive(false);

                    }
                }

            }

        }
        
        if (other.name == "note_line1(Clone)")
        {
            if (Input.GetKeyDown("f"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_2line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
            }
        }
        if (other.name == "note_line1(Clone)")
        {
            if (Input.GetKeyDown("j"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_3line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
            }
        }
        if (other.name == "note_line1(Clone)")
        {
            if (Input.GetKeyDown("k"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_4line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
            }
        }
    }
    */

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "bar(Clone)")
        {
            
        }
        else
        {
            JudgeF();
        }
    }
    /* private void OnTriggerStay(Collider other)
     {
         if(other.name == "note_line1(Clone)")
         {
                 JudgeA();
                 lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                 SetCount();
                 other.gameObject.SetActive(false);


         }
     }
     */
   
    void SetCount() //콤보가 상승하는 클래스입니다.
    {
        combo.SendMessage("COMBO");
    }
    // 판정 이펙트 발생 클래스들입니다.
    void JudgeA()
    {
        ScoreGuy.SendMessage("JudgeA_Score");
        JudgeA_Effect.SetActive(true);
        JudgeA_Effect.SendMessage("Judges");
        Boost.value += 0.02f;
    }
    void JudgeB()
    {
        ScoreGuy.SendMessage("JudgeB_Score");
        JudgeB_Effect.SetActive(true);
        JudgeB_Effect.SendMessage("Judges");
        Boost.value += 0.01f;
    }
    void JudgeC()
    {
        ScoreGuy.SendMessage("JudgeC_Score");
        JudgeC_Effect.SetActive(true);
        JudgeC_Effect.SendMessage("Judges");
    }
    void JudgeD()
    {
        ScoreGuy.SendMessage("JudgeD_Score");
        JudgeD_Effect.SetActive(true);
        JudgeD_Effect.SendMessage("Judges");
    }
    void JudgeE()
    {
        ScoreGuy.SendMessage("JudgeE_Score");
        JudgeE_Effect.SetActive(true);
        JudgeE_Effect.SendMessage("Judges");
    }
    void JudgeF()
    {
        JudgeF_Effect.SetActive(true);
        JudgeF_Effect.SendMessage("Judges");
        combo.SendMessage("F_COMBO"); //F 판정은 콤보 수치를 초기화합니다.
    }
    // 판정에 따라 이펙트를 달리 할 수도 있습니다. 그렇게 진행하려면 각 Judge 클래스마다 이펙트 발생을 넣습니다.

    // Update is called once per frame
    void Update()

    {
        RaycastHit Notes_line1;

        string line1 = PlayerPrefs.GetString("line1");
        Line1Key = (KeyCode)System.Enum.Parse(typeof(KeyCode), line1); // 0103 Update
       // Line1Key = KeyCode.LeftShift;
       // Line_Plus = KeyCode.D;
        //  RaycastHit Notes_line2;
        //  RaycastHit Notes_line3;
        //  RaycastHit Notes_line4;

        // 판정 검사 스크립트입니다.
        if (Input.GetKeyDown(Line1Key))
        {

            if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_5_value))
            {
                if (Notes_line1.collider.name == "note_line1(Clone)")
                {
                    JudgeA();
                    lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line1.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_4_value))
            {
                if (Notes_line1.collider.name == "note_line1(Clone)")
                {
                    JudgeB();
                    lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line1.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_3_value))
            {
                if (Notes_line1.collider.name == "note_line1(Clone)")
                {
                    JudgeC();
                    lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line1.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_2_value))
            {
                if (Notes_line1.collider.name == "note_line1(Clone)")
                {
                    JudgeD();
                    lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line1.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_1_value))

            {
                if (Notes_line1.collider.name == "note_line1(Clone)")
                {
                    JudgeE();
                    lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line1.collider.gameObject.SetActive(false);
                }
            }
        }

            /*
            if (!Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_2_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_1_value))

                {
                    if (Notes_line1.collider.name == "note_line1(Clone)")
                    {
                        JudgeE();
                        lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        Notes_line1.collider.gameObject.SetActive(false);
                    }
                }
                else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_3_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_2_value))
                {
                    if (Notes_line1.collider.name == "note_line1(Clone)")
                    {
                        JudgeD();
                        lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        Notes_line1.collider.gameObject.SetActive(false);
                    }
                }
                else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_4_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_3_value))
                {
                    if (Notes_line1.collider.name == "note_line1(Clone)")
                    {
                        JudgeC();
                        lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        Notes_line1.collider.gameObject.SetActive(false);
                    }
                }
                else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_5_value) && )
                {
                    if (Notes_line1.collider.name == "note_line1(Clone)")
                    {
                        JudgeB();
                        lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        Notes_line1.collider.gameObject.SetActive(false);
                    }
                }
                else if (Physics.Raycast(transform.position, transform.forward, out Notes_line1, Judge_5_value))
                {
                    if (Notes_line1.collider.name == "note_line1(Clone)")
                    {
                        JudgeA();
                        lightEffects_1line = (GameObject)Instantiate(lightEffect_1line, this.transform.position, Quaternion.Euler(effect_rotation));
                        SetCount();
                        Notes_line1.collider.gameObject.SetActive(false);
                    }
                }



            }
        */


        /*

            if (Input.GetKeyDown("f"))
        {
            if (!Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_2_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_1_value))

            {
                if (Notes_line2.collider.name == "note_line1(Clone)")
                {
                    JudgeE();
                    lightEffects_2line = (GameObject)Instantiate(lightEffect_2line, Notes_line2.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line2.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_3_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_2_value))
            {
                if (Notes_line2.collider.name == "note_line1(Clone)")
                {
                    JudgeD();
                    lightEffects_2line = (GameObject)Instantiate(lightEffect_2line, Notes_line2.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line2.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_4_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_3_value))
            {
                if (Notes_line2.collider.name == "note_line1(Clone)")
                {
                    JudgeC();
                    lightEffects_2line = (GameObject)Instantiate(lightEffect_2line, Notes_line2.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line2.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_4_value))
            {
                if (Notes_line2.collider.name == "note_line1(Clone)")
                {
                    JudgeB();
                    lightEffects_2line = (GameObject)Instantiate(lightEffect_2line, Notes_line2.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line2.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line2, Judge_6_value) || Physics.Raycast(transform.position, -transform.forward, out Notes_line2, Judge_7_value))
            {
                if(Notes_line2.collider.name == "note_line1(Clone)")
                {
                    JudgeA();
                    lightEffects_2line = (GameObject)Instantiate(lightEffect_2line, Notes_line2.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line2.collider.gameObject.SetActive(false);
                }
            }
        }
            
        if (Input.GetKeyDown("j"))
        {
            if (!Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_2_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_1_value))

            {
                if (Notes_line3.collider.name == "note_line1(Clone)")
                {
                    JudgeE();
                    lightEffects_3line = (GameObject)Instantiate(lightEffect_3line, Notes_line3.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line3.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_3_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_2_value))
            {
                if (Notes_line3.collider.name == "note_line1(Clone)")
                {
                    JudgeD();
                    lightEffects_3line = (GameObject)Instantiate(lightEffect_3line, Notes_line3.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line3.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_4_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_3_value))
            {
                if (Notes_line3.collider.name == "note_line1(Clone)")
                {
                    JudgeC();
                    lightEffects_3line = (GameObject)Instantiate(lightEffect_3line, Notes_line3.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line3.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_4_value))
            {
                if (Notes_line3.collider.name == "note_line1(Clone)")
                {
                    JudgeB();
                    lightEffects_3line = (GameObject)Instantiate(lightEffect_3line, Notes_line3.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line3.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line3, Judge_6_value) || Physics.Raycast(transform.position, -transform.forward, out Notes_line3, Judge_7_value))
            {
                if (Notes_line3.collider.name == "note_line1(Clone)")
                {
                    JudgeA();
                    lightEffects_3line = (GameObject)Instantiate(lightEffect_3line, Notes_line3.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line3.collider.gameObject.SetActive(false);
                }
            }
        }
        if (Input.GetKeyDown("k"))
        {
            if (!Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_2_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_1_value))

            {
                if (Notes_line4.collider.name == "note_line1(Clone)")
                {
                    JudgeE();
                    lightEffects_4line = (GameObject)Instantiate(lightEffect_4line, Notes_line4.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line4.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_3_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_2_value))
            {
                if (Notes_line4.collider.name == "note_line1(Clone)")
                {
                    JudgeD();
                    lightEffects_4line = (GameObject)Instantiate(lightEffect_4line, Notes_line4.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line4.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_4_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_3_value))
            {
                if (Notes_line4.collider.name == "note_line1(Clone)")
                {
                    JudgeC();
                    lightEffects_4line = (GameObject)Instantiate(lightEffect_4line, Notes_line4.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line4.collider.gameObject.SetActive(false);
                }
            }
            else if (!Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_4_value))
            {
                if (Notes_line4.collider.name == "note_line1(Clone)")
                {
                    JudgeB();
                    lightEffects_4line = (GameObject)Instantiate(lightEffect_4line, Notes_line4.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line4.collider.gameObject.SetActive(false);
                }
            }
            else if (Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_5_value) && Physics.Raycast(transform.position, transform.forward, out Notes_line4, Judge_6_value) || Physics.Raycast(transform.position, -transform.forward, out Notes_line4, Judge_7_value))
            {
                if (Notes_line4.collider.name == "note_line1(Clone)")
                {
                    JudgeA();
                    lightEffects_4line = (GameObject)Instantiate(lightEffect_4line, Notes_line4.transform.position, Quaternion.Euler(effect_rotation));
                    SetCount();
                    Notes_line4.collider.gameObject.SetActive(false);
                }
            }
        }
        */

    Debug.DrawRay(transform.position, -transform.forward * 10.4f, Color.red);
        Destroy(lightEffects_1line, 0.2f);
       // Destroy(lightEffects_2line, 0.2f);
       // Destroy(lightEffects_3line, 0.2f);
       // Destroy(lightEffects_4line, 0.2f);
    }

}

