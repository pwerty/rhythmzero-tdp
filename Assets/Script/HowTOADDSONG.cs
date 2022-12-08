using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowTOADDSONG : MonoBehaviour {

    private void Start()
    {
    }

    /*
     * 곡을 추가하는 방법에 대해 설명합니다.
     * 1. BGM(.mp3) 파일, 각 패턴 파일(.txt)이 있어야합니다. 난이도는 둘 중 하나는 꼭 있어야합니다
     *  1-2. Resources/BGM에는 .mp3, Resource/BmsFiles에는 .txt 파일을 넣습니다. 각 폴더에 같은 이름이지만 다른 확장자의 파일이 있는경우 Null 오류가 발생할 것 입니다..
     * 2. 버튼을 추가하고, Selects_guys에 버튼 Press 시 나타날 이미지와 설명을 추가해줍니다.
     * 3. 버튼에는 다른 버튼들 처럼 OnClick 이벤트를 비슷하게 설정해주지만, Canvas에 보내는 SendMessage ?는 곡 이름대로 합니다.
     * 4. Canvas의 Selector 스크립트에 곡 이름에 맞는 새로운 클래스를 추가해줍니다.
     * 5. selectindex가 곡이 추가되는대로 더 사용될테니 재량껏 추가하도록 합니다.
     */


}
