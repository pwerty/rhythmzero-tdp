using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judge_Trigger : MonoBehaviour {

    public Vector3 effect_rotation;
    public float distance;
    public Text combo;
    private int count;
    public GameObject lightEffects;
    public GameObject lightEffect_1line;
    public GameObject lightEffect_2line;
    public GameObject lightEffect_3line;
    public GameObject lightEffect_4line;
    /*
    void OnTriggerEnter(Collider other)
    {

        if(other.name == "note_line1(Clone)")
        {
            
        Debug.Log("1번 노트가 지나갔다 bro..");
            if (Input.GetKey("d"))
            {
                Instantiate(effect, other.transform.position, Quaternion.Euler(effect_rotation));
            }

        }
        if(other.name == "note_line2(Clone)")
        {
            Debug.Log("2번 노트가 지나갔다 bro..");
            if (Input.GetKey("f"))
            {
                Instantiate(effect, other.transform.position, Quaternion.Euler(effect_rotation));
            }
        }
        if(other.name == "note_line3(Clone)")
        {
            Debug.Log("3번 노트가 지나갔다 bro..");
            if (Input.GetKey("j"))
            {
                Instantiate(effect, other.transform.position, Quaternion.Euler(effect_rotation));
            }
        }
        if(other.name == "note_line4(Clone)")
        {
            Debug.Log("4번 노트가 지나갔다 bro..");
            if (Input.GetKey("k"))
            {
                Instantiate(effect, other.transform.position, Quaternion.Euler(effect_rotation));
            }
        }
    }
    */
    void OnTriggerStay(Collider other)
    {
        
        //SetCount();
        //other.gameObject.SetActive(false);
        /*
        Debug.Log(other.transform.position.z);
        Debug.Log(this.transform.position.z);
        Debug.Log(other.transform.position.z - this.transform.position.z);
        */
        if (other.name == "note_line1(Clone)")
        {


            Debug.Log("1번 노트가 지나갔다 bro..");
            if (Input.GetKeyDown("d"))
            {
                lightEffects = (GameObject) Instantiate(lightEffect_1line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
                Debug.Log(other.transform.position.z);
                Debug.Log(this.transform.position.z);
                Debug.Log(other.transform.position.z - this.transform.position.z);

                // 판정 발생 검사 클래스 작동 부분입니다. if문에는 if(판정선 위 좌표 and 판정선 아래 좌표)를 지켜서 작성되었습니다.
                if (other.transform.position.z - this.transform.position.z > -0.03f && other.transform.position.z - this.transform.position.z <= 0.039f)
                {
                    JudgeA();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.039f && other.transform.position.z - this.transform.position.z <= 0.045f)
                {
                    JudgeB();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.045f && other.transform.position.z - this.transform.position.z <= 0.049f)
                {
                    JudgeC();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.049f && other.transform.position.z - this.transform.position.z <= 0.055f)
                {
                    JudgeD();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.055f)
                {
                    JudgeE();
                }
                //1016 판정 개념 테스트


            }

        }
        if (other.name == "note_line2(Clone)")
        {
            Debug.Log("2번 노트가 지나갔다 bro..");
            if (Input.GetKeyDown("f"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_2line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
                Debug.Log(other.transform.position.z);
                Debug.Log(this.transform.position.z);
                Debug.Log(other.transform.position.z - this.transform.position.z);
                if (other.transform.position.z - this.transform.position.z > -0.03f && other.transform.position.z - this.transform.position.z <= 0.039f)
                {
                    JudgeA();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.039f && other.transform.position.z - this.transform.position.z <= 0.045f)
                {
                    JudgeB();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.045f && other.transform.position.z - this.transform.position.z <= 0.049f)
                {
                    JudgeC();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.049f && other.transform.position.z - this.transform.position.z <= 0.055f)
                {
                    JudgeD();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.055f)
                {
                    JudgeE();
                }
            }
        }
        if (other.name == "note_line3(Clone)")
        {
            Debug.Log("3번 노트가 지나갔다 bro..");
            if (Input.GetKeyDown("j"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_3line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
                Debug.Log(other.transform.position.z);
                Debug.Log(this.transform.position.z);
                Debug.Log(other.transform.position.z - this.transform.position.z);
                if (other.transform.position.z - this.transform.position.z > -0.03f && other.transform.position.z - this.transform.position.z <= 0.039f)
                {
                    JudgeA();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.039f && other.transform.position.z - this.transform.position.z <= 0.045f)
                {
                    JudgeB();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.045f && other.transform.position.z - this.transform.position.z <= 0.049f)
                {
                    JudgeC();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.049f && other.transform.position.z - this.transform.position.z <= 0.055f)
                {
                    JudgeD();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.055f)
                {
                    JudgeE();
                }
            }
        }
        if (other.name == "note_line4(Clone)")
        {
            Debug.Log("4번 노트가 지나갔다 bro..");
            if (Input.GetKeyDown("k"))
            {
                lightEffects = (GameObject)Instantiate(lightEffect_4line, other.transform.position, Quaternion.Euler(effect_rotation));
                SetCount();
                other.gameObject.SetActive(false);
                Debug.Log(other.transform.position.z);
                Debug.Log(this.transform.position.z);
                Debug.Log(other.transform.position.z - this.transform.position.z);
                if (other.transform.position.z - this.transform.position.z > -0.03f && other.transform.position.z - this.transform.position.z <= 0.039f)
                {
                    JudgeA();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.039f && other.transform.position.z - this.transform.position.z <= 0.045f)
                {
                    JudgeB();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.045f && other.transform.position.z - this.transform.position.z <= 0.049f)
                {
                    JudgeC();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.049f && other.transform.position.z - this.transform.position.z <= 0.055f)
                {
                    JudgeD();
                }
                else if (other.transform.position.z - this.transform.position.z > 0.055f)
                {
                    JudgeE();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        JudgeF();
        
        Debug.Log("F" + other.transform.position.z);
        Debug.Log("F" + this.transform.position.z);
        Debug.Log("F" + (other.transform.position.z - this.transform.position.z));
        
    }

    void SetCount()
    {
        GameObject.Find("COMBO").SendMessage("COMBO");
    }
    void JudgeA()
    {
        GameObject.Find("PPAP").SetActive(true);
        GameObject.Find("PPAP").SendMessage("Judges");
    }
    void JudgeB()
    {
        GameObject.Find("PPBP").SetActive(true);
        GameObject.Find("PPBP").SendMessage("Judges");
    }
    void JudgeC()
    {
        GameObject.Find("PPCP").SetActive(true);
        GameObject.Find("PPCP").SendMessage("Judges");
    }
    void JudgeD()
    {
        GameObject.Find("PPDP").SetActive(true);
        GameObject.Find("PPDP").SendMessage("Judges");
    }
    void JudgeE()
    {
        GameObject.Find("PPEP").SetActive(true);
        GameObject.Find("PPEP").SendMessage("Judges");
    }
    void JudgeF()
    {
        GameObject.Find("PPFP").SetActive(true);
        GameObject.Find("PPFP").SendMessage("Judges");
        count = 0; //F 판정은 콤보 수치를 초기화합니다.
    }
    // 판정에 따라 이펙트를 달리 할 수도 있습니다. 그렇게 진행하려면 각 Judge 클래스마다 이펙트 발생을 넣습니다.
    void Start () {
        count = 0;

	}

    // Update is called once per frame
    void Update()
    {
        Destroy(lightEffects, 0.2f);
        // distance = (this.transform.position.x - other.transform.position.x);
    }

}
