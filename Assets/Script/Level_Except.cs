using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Except : MonoBehaviour {

    // Use this for initialization
    public Selector SelectGuy;
    public GameObject HardButton;
        /*
         * 만약 특정 곡의 패턴이 둘 중 한가지만 있다면, 없는 패턴의 버튼을 비활성화 하는 스크립트입니다.
         * */

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (SelectGuy.selectindex == 4) //RFC가 골라지면
        {
            HardButton.SetActive(false); //하드 버튼은 사용 할 수 없습니다.
        }
        else
        {
            HardButton.SetActive(true);
        }
        */ // 아직 기능 수행 안됨

    }
}
