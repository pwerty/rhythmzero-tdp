using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteFalling : MonoBehaviour {
    /*
    0.125 / (BPM / 60)초마다 노트가 등장합니다. 제일 작은 단위 입니다. //수정
   파일 내에 구현하는건 제일 적은 값으로 낙하하며 이 낙하 속도를 1배속(1x)라고 지칭합니다.
    1초에 노트 웨이브가 얼마나 지나가냐의 수치가 표시됩니다.
        */
    public float speed;
    public bool isStart = false;

    public int channel;
    public float noteTime;

    public float destroyPositionZ;
    public float destroyDelayTime;

    // NoteBar noteSettings = GameObject.Find("Reading_Generating").GetComponent<NoteBar>();
    void Start()
    {


        /*
            startTime = System.DateTime.Now.Ticks;
            startZ = transform.position.z;
            */

    }
    /*void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Judges" && gameObject.name != "bar(Clone)")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }*/



    void Update () {
        if (isStart == true)
        {
            StartCoroutine(Move());
        }
        
       
    }

    IEnumerator Move()
    {
        if (transform.position.z > destroyPositionZ)
        {

            transform.Translate(Vector3.back * speed * Time.smoothDeltaTime);
        }
        else
        {
            Destroy(gameObject);
        }

        yield return null;
    }
}
