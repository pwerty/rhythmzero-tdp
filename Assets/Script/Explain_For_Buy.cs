using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explain_For_Buy : MonoBehaviour {

    public GameObject Scroll1;
    public GameObject Scroll2;
    public GameObject Scroll3;
    public GameObject Scroll4;
    public GameObject Scroll5;
    public GameObject Scroll6;
    public GameObject Scroll7;
    public GameObject Scroll8;
    public GameObject Scroll9;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Scroll1.activeSelf == true)
        {
            this.GetComponent<Text>().text = "프로필의 얼굴을 맡는 캐릭터를 설정합니다.";
        }
        else if(Scroll2.activeSelf == true)
        {
            this.GetComponent<Text>().text = "기어 스킨은 플레이를 더 돋보이게 해줄 것 입니다.";
        }
        else if(Scroll3.activeSelf == true)
        {
            this.GetComponent<Text>().text = "노트 스킨은 플레이어의 눈을 더 편하게 할 수 있을겁니다.";
        }
        else if(Scroll4.activeSelf == true)
        {
            this.GetComponent<Text>().text = "콤보 폰트를 설정하여 본인 눈에 맞게 가독성을 높여보세요.";
        }
        else if(Scroll5.activeSelf == true)
        {
            this.GetComponent<Text>().text = "부스트 폰트를 설정하여 본인 눈에 맞게 가독성을 높여보세요.";
        }
        else if(Scroll6.activeSelf == true)
        {
            this.GetComponent<Text>().text = "프로필 플레이트는 프로필 카드의 색을 설정합니다.";
        }
        else if(Scroll7.activeSelf == true)
        {
            this.GetComponent<Text>().text = "코멘트를 통해 기분을 표현해보세요.";
        }
        else if(Scroll8.activeSelf == true)
        {
            this.GetComponent<Text>().text = "매 판정이 발생 할때마다 개성이 강조됩니다.";
        }
        else if(Scroll9.activeSelf == true)
        {
            this.GetComponent<Text>().text = "그 외의 다양한 아이템을 살펴보세요.";
        }
        else
        {
            this.GetComponent<Text>().text = "이 항목은 뭐야";
        }
	}
}
