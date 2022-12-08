using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereYouComing : MonoBehaviour {
    // Store Scene, 즉 Equipment 씬은 Free, Mission, Network 모드 대기 상태에서 언제나 이용 할 수 있습니다.
    // 들어온 후 나갔을 때 원래의 대기 상태로 돌아 갈 수 있도록 하는 스크립트입니다.

        // 이동 전 씬에서 static 함수에 값을 주고, static 값에 따라 ESC 키를 눌렀을 때 도로 이동하는 경로를 다르게 주면 됩니다.  2017 11 29

    static public int WhereICome;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
