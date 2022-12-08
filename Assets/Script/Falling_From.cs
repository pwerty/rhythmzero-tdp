using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Falling_From : MonoBehaviour
{
    /*
    public List<GameObject> notelist_1line = new List<GameObject>();
    public List<GameObject> notelist_2line = new List<GameObject>();
    public List<GameObject> notelist_3line = new List<GameObject>();
    public List<GameObject> notelist_4line = new List<GameObject>();
    public NoteBar noteBar;
    public float spendTime;
    int index_1line;
    int index_2line;
    int index_3line;
    int index_4line;
    void Start () {
        notelist_1line = noteBar.noteList_1line;
        notelist_2line = noteBar.noteList_2line;
        notelist_3line = noteBar.noteList_3line;
        notelist_4line = noteBar.noteList_4line;



        Fall();
    }

    // Update is called once per frame
    void Update()
    {

        print(spendTime);
    }
 
    void Fall()
    {

        for(index_1line = 0;  notelist_1line.Count > index_1line; index_1line++)
        {
            notelist_1line[index_1line].SendMessage("Go");
            spendTime += Time.deltaTime;
        }
        for (index_2line = 0; notelist_2line.Count > index_2line; index_2line++)
        {
            notelist_2line[index_2line].SendMessage("Go");
            spendTime += Time.deltaTime;
        }
        for (index_3line = 0; notelist_3line.Count > index_3line; index_3line++)
        {
            notelist_3line[index_3line].SendMessage("Go");
            spendTime += Time.deltaTime;
        }
        for (index_4line = 0; notelist_4line.Count > index_4line; index_4line++)
        {
            notelist_4line[index_4line].SendMessage("Go");
            spendTime += Time.deltaTime;
        }
        


    }
    */
    public int keyMode;

    public float bpm;

    public bool isStart = false;
    public bool isReady = false;

    float WaitTime = 0f; //1204 지연시간 테스트

    float nextTime = 0f;
    float nextSample = 0f;

    float secondPerBar = 0f; // Bar 당 시간(초).
    float secondPerBeat = 0f; // Beat 당 시간(초).
    float samplePerBar = 0f; // Bar 당 PCM 샘플.
    float samplePerBeat = 0f; // Beat 당 PCM 샘플.
    public float beatPerBar; // Bar 당 비트수 (GameManager에서 지정.)

    public int timeRateBySpeed; // 거리 계수

    public AudioClip ticSound;
    public AudioClip bgmSound;
    AudioSource ticPlayer;

    static public AudioSource bgmPlayer;
    static public bool Video_Settings;

    public GameObject MV;
    public GameObject CountDown;
    public GameObject ResultSender;
    int beatCount = 0;

    public List<NoteFalling> noteObj_Line_1;
    public List<NoteFalling> noteObj_Line_2;
    public List<NoteFalling> noteObj_Line_3;
    public List<NoteFalling> noteObj_Line_4;
    public List<NoteFalling> bar_Line;

    int noteIndex_1 = 0;
    int noteIndex_2 = 0;
    int noteIndex_3 = 0;
    int noteIndex_4 = 0;
    int barIndex = 0;

    bool isBgmPlay = false;
    bool Should_MV_Play = false;
    float TimeCalc = 0;
    public bool AdminSkipBool;
    // Use this for initialization
    void Start()
    {
       Video_Settings =  bool.Parse(PlayerPrefs.GetString("VideoToggle_Switch"));

        ticPlayer = gameObject.AddComponent<AudioSource>();
        ticPlayer.clip = ticSound;

        bgmPlayer = gameObject.AddComponent<AudioSource>();
        bgmPlayer.clip = bgmSound;
        

        secondPerBar = 60.0f / bpm * 4f;                            // Bar 당 시간(초)
        secondPerBeat = 60.0f / bpm * 4f / beatPerBar;              // Beat 당 시간(초).
        samplePerBar = secondPerBar * bgmPlayer.clip.frequency;     // Bar 당 PCM 샘플.
        samplePerBeat = secondPerBeat * bgmPlayer.clip.frequency;   // Beat 당 PCM 샘플.

        //StartCoroutine(Create()); // 노트생성 코루틴 시작.

        VideoPlayer Videoguy = MV.GetComponent<VideoPlayer>();
        VideoClip video = Resources.Load("MV/" + NoteBar_.bmsName) as VideoClip;
        Videoguy.clip = video;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Should_MV_Play == false)
        {*/
            if (bgmPlayer.isPlaying /*&& Video_Settings*/)
            {
                MV.SetActive(true);
            }
            else
            {
                MV.SetActive(false);
            }


          //  Should_MV_Play = true;
       // }

        

        if (Time.timeSinceLevelLoad - WaitTime - TimeCalc  > CountDown.GetComponent<VideoPlayer>().clip.length + bgmPlayer.clip.length + 3f || AdminSkipBool)
        {
            if(Combo.IsMissionPlaying) //너 미션모드니?
            {
                MissionManager.NextStage();
                SceneManager.LoadScene("Mission_result");
                //MissionManager.StageCount++;
                //TimeCalc = Time.timeSinceLevelLoad;
                
                
            }
            else
            {
                if (SceneManager.GetActiveScene().name == "RZ_tutorial")
                {
                    SceneManager.LoadScene("Free_select");
                }
                else if (SceneManager.GetActiveScene().name == "multi_test")
                {
                    SceneManager.LoadScene("result_test_multi");
                }
                else
                {
                    SceneManager.LoadScene("result");
                }
            }


        } // 결과창 넘어가기

        if (CountDown.GetComponent<VideoPlayer>().isPlaying == false)
        {
            Ingame_Network.Am_I_Ready = true;

            if(SceneManager.GetActiveScene().name == "multi_test")
            {


                if (isStart == true && CountDown.GetComponent<VideoPlayer>().isPlaying == false && isReady == false)// && Ingame_Network.IsEnemyReady == true)/*CountDown.GetComponent<VideoPlayer>().isPlaying == false*/
                                                                                                                    // 지금 이렇게 하면 싱글 플레이 못함. 테스트 끝나는대로 원래로 수정할것
                {
                    // StartCoroutine(Create());// 노트생성 코루틴 시작.
                    if (Ingame_Network.IsEnemyReady == false)
                    {
                        WaitTime += Time.deltaTime;
                    }
                    else
                    {
                        isReady = true;
                    }


                }
            }
            else   // 멀티 플레이 씬이 아니면 싱글 시작 - 더 효율적으로 할 수 있을 듯
            {
                if (isStart == true && CountDown.GetComponent<VideoPlayer>().isPlaying == false)
                {
                    isReady = true;
                }
            }


            if (isReady == true)
            {
                StartCoroutine(Create());// 노트생성 코루틴 시작.
            }


        }
    }

    // 노트생성 코루틴.
    IEnumerator Create()
    {
        yield return null;
    double VideoLength = CountDown.GetComponent<VideoPlayer>().clip.length;
        if (Time.timeSinceLevelLoad - VideoLength - WaitTime >= (secondPerBar * (timeRateBySpeed - 1)) && isBgmPlay == false)
        {
            bgmPlayer.Play();
            isBgmPlay = true;



        }

        if (Time.timeSinceLevelLoad - VideoLength - WaitTime >= nextTime && isBgmPlay == false)
        {
            if (noteObj_Line_1.Count > noteIndex_1)
            {
                if (nextTime >= (noteObj_Line_1[noteIndex_1].noteTime))
                {
                    noteObj_Line_1[noteIndex_1].isStart = true;
                    noteIndex_1++;
                }
            }
            if (noteObj_Line_2.Count > noteIndex_2)
            {
                if (nextTime >= (noteObj_Line_2[noteIndex_2].noteTime))
                {
                    noteObj_Line_2[noteIndex_2].isStart = true;
                    noteIndex_2++;
                }
            }
            if (noteObj_Line_3.Count > noteIndex_3)
            {
                if (nextTime >= (noteObj_Line_3[noteIndex_3].noteTime))
                {
                    noteObj_Line_3[noteIndex_3].isStart = true;
                    noteIndex_3++;
                }
            }
            if (noteObj_Line_4.Count > noteIndex_4)
            {
                if (nextTime >= (noteObj_Line_4[noteIndex_4].noteTime))
                {
                    noteObj_Line_4[noteIndex_4].isStart = true;
                    noteIndex_4++;
                }
            }
            if (bar_Line.Count > barIndex)
            {
                if (nextTime >= bar_Line[barIndex].noteTime)
                {
                    bar_Line[barIndex].isStart = true;
                    barIndex++;
                }
            }

            nextTime += secondPerBeat;
        }

        if (bgmPlayer.timeSamples >= nextSample && isBgmPlay == true)
        {

            if (noteObj_Line_1.Count > noteIndex_1)
            {
                if (bgmPlayer.timeSamples >= (noteObj_Line_1[noteIndex_1].noteTime - (secondPerBar * (timeRateBySpeed - 1))) * bgmPlayer.clip.frequency)
                {
                    noteObj_Line_1[noteIndex_1].isStart = true;
                    noteIndex_1++;
                }
            }
            if (noteObj_Line_2.Count > noteIndex_2)
            {
                if (bgmPlayer.timeSamples >= (noteObj_Line_2[noteIndex_2].noteTime - (secondPerBar * (timeRateBySpeed - 1))) * bgmPlayer.clip.frequency)
                {
                    noteObj_Line_2[noteIndex_2].isStart = true;
                    noteIndex_2++;
                }
            }
            if (noteObj_Line_3.Count > noteIndex_3)
            {
                if (bgmPlayer.timeSamples >= (noteObj_Line_3[noteIndex_3].noteTime - (secondPerBar * (timeRateBySpeed - 1))) * bgmPlayer.clip.frequency)
                {
                    noteObj_Line_3[noteIndex_3].isStart = true;
                    noteIndex_3++;
                }
            }
            if (noteObj_Line_4.Count > noteIndex_4)
            {
                if (bgmPlayer.timeSamples >= (noteObj_Line_4[noteIndex_4].noteTime - (secondPerBar * (timeRateBySpeed - 1))) * bgmPlayer.clip.frequency)
                {
                    noteObj_Line_4[noteIndex_4].isStart = true;
                    noteIndex_4++;
                }
            }
            if (bar_Line.Count > barIndex)
            {
                if (bgmPlayer.timeSamples >= (bar_Line[barIndex].noteTime - (secondPerBar * (timeRateBySpeed - 1))) * bgmPlayer.clip.frequency)
                {
                    bar_Line[barIndex].isStart = true;
                    barIndex++;
                }
            }


            /*if (beatCount % (4 * beatPerBar / 16) == 0)
            {
                if (isTic)
                {
                    ticPlayer.Play();
                }
            }
            */
            nextSample += samplePerBeat;
            beatCount++;
        }

    }

   static public void VolumeUP()
    {


        bgmPlayer.volume = 1.0f;
        
        /* if(bgmPlayer.volume > 0.7f)
         {
             bgmPlayer.volume = 1f;
         }
         else
         {
             bgmPlayer.volume = bgmPlayer.volume + 0.2f;
         }*/
    }
    
   static public void VolumeDOWN()
    {
        /*  if(bgmPlayer.volume < 0.2f)
          {

          }
          else
          {
              bgmPlayer.volume = bgmPlayer.volume - 0.15f;
          }*/
        bgmPlayer.volume = 0.4f;
       
    }
    
}