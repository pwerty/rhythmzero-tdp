using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class NoteBar_ : MonoBehaviour
{
    int notePrefab_Value;

    public GameObject notePrefab; //노트 프리팹을 넣습니다. 후에 복수로 생성 //Default
    public GameObject notePrefab1;
    public GameObject notePrefab2;
    public GameObject notePrefab3;
    public GameObject notePrefab4;

    public GameObject barPrefab; //마디마다 끊는 바를 표시합니다. 게임 플레이에 간접적인 도움만 제공합니다. 없어도 됨

    static public float PlaySpeed; // 플레이 배속입니다. 노래 선택창에서 조정 할 수 있게 변경

    float linePositionX = 0f;
    float beatPerBar = 32f * PlaySpeed; // Bar 당 비트수.
    float defaultSpeed = 10 * PlaySpeed;
    int timeRateBySpeed = 2;// 거리 계수

    GameObject note;
    NoteFalling NoteFalling;

    static public bool IsSelectHard = false;
    string HardORNot;
    static public string bmsName = "bedlam"; // entertheuniverse // UAD // godmode // nice_shot // bedlam

    static public string note_Prefab_name;
    public bool IsMissionPlay;
    // 메트로놈 재생 여부
    // public bool isTic;

    // Use this for initialization
    private void Awake()
    {
        //IsSelectHard = true;
        PlaySpeed = 1f;//Ingame_CustomSett.PlaySpeed;
        beatPerBar = 32f * PlaySpeed; // Bar 당 비트수.
        defaultSpeed = 10 * PlaySpeed;
        notePrefab_Value = PlayerPrefs.GetInt("Note_Switch");

        IsMissionPlay = Combo.IsMissionPlaying;

        note_Prefab_name = notePrefab.name; //예비 사용 1213 문서

    }

    IEnumerator Start()
    {
        // 화면 비율.
        //Screen.SetResolution(Screen.width * 16 / 9, Screen.width, true);

        // bms 파일 로드.
        //string[] lineData = File.ReadAllLines(Application.dataPath + "/BmsFiles/" + "test.bms");
        //string[] lineData2 = File.ReadAllLines("Assets/Resources/BmsFiles/" + "test.bms");

        /*  if(IsMissionPlay)
          {
              bmsName = MissionManager.bmsName;
              IsSelectHard = MissionManager.IsSelectHard;
          }*/

        /*  if (notePrefab_Value == 1)
          {
              notePrefab = notePrefab2;
          }
          else if(notePrefab_Value == 2)
          {
              notePrefab = notePrefab3;
          }
          else
          {

          }*/

        if (Combo.IsMissionPlaying) //미션 플레이인경우 조건부 확인
        {
            if (Mission.Mission_Switcher == 7) //7번미션이면
            {
                notePrefab = notePrefab4; // White 고정
            }
        }
        else //미션이 아니시면
        {
            if (notePrefab_Value == 1) // 하던거 할게여 ㅋ
            {
                notePrefab = notePrefab2;
            }
            else if (notePrefab_Value == 2)
            {
                notePrefab = notePrefab3;
            }
            else if (notePrefab_Value == 3)
            {
                notePrefab = notePrefab4;
            }
        }

        if (IsSelectHard == true)
        {
            HardORNot = "_hard";
        }
        else
        {
            HardORNot = "_normal";
        }
        if (SceneManager.GetActiveScene().name == "RZ_tutorial")
        {
            bmsName = "tutorial";
        }
        TextAsset ta = Resources.Load("BmsFiles/" + bmsName + HardORNot) as TextAsset;
        string strData = "" + ta.text;
        string[] lineData = strData.Split('\n');

        // BMS 노트데이터 파싱.
        ReadNote2 bmsLoader = GameObject.Find("BmsLoader").GetComponent<ReadNote2>();
        bmsLoader.BmsLoad(lineData);

        Bms bms = bmsLoader.getBms();

        // 시작선.
        GameObject topplane = GameObject.Find("topplane");


        //플레이하는 패턴에따라 topplane 위치가 달라집니다.
        if (bmsName == "deborah")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 18.58f * PlaySpeed);
        }
        else if (bmsName == "frozen_eyes")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 15.71f * PlaySpeed);
        }
        else if (bmsName == "houseplan")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 19.59f * PlaySpeed);
        }
        else if (bmsName == "rfc")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 19f * PlaySpeed);
        }
        else if (bmsName == "chun_gi")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 17.19f * PlaySpeed);
        }
        else if (bmsName == "entertheuniverse")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 17.00f * PlaySpeed);
        }
        else if (bmsName == "UAD")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 19.22f * PlaySpeed);
        }
        else if (bmsName == "lightfall")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 19.22f * PlaySpeed);
        }
        else if (bmsName == "nice_shot")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 17.50f * PlaySpeed);
        }
        else if (bmsName == "bedlam")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 15.08f * PlaySpeed);
        }
        else if (bmsName == "godmode")
        {
            topplane.transform.position = new Vector3(topplane.transform.position.x, topplane.transform.position.y, 15.50f * PlaySpeed);
        }

        float startPositionZ = topplane.transform.position.z;

        // 판정선
        GameObject lineJudgment = GameObject.Find("Line_Judgement");
        float judgmentPositionZ = lineJudgment.transform.position.z;

        // 시작선 ~ 판정선 거리.
        //print(Vector3.Distance(plane_Top.transform.position, lineJudgment.transform.position));
        //float distance = 17.81831f;

        // 노트 라인.
        // GameObject lineCenter = GameObject.Find("LineCenter");

        // 노트 소멸 위치.
        float destroyDelayPositionZ = 30.0f;

        // 노트 간격 비율.
        float noteWidthRate = 1.8f;

        // 노트 프리팹 생성 및 리스트 저장.
        List<NoteFalling> noteObj_Line_1 = new List<NoteFalling>();
        List<NoteFalling> noteObj_Line_2 = new List<NoteFalling>();
        List<NoteFalling> noteObj_Line_3 = new List<NoteFalling>();
        List<NoteFalling> noteObj_Line_4 = new List<NoteFalling>();
        List<NoteFalling> bar_Line = new List<NoteFalling>();

        bool isLongNoteStart_1 = true;
        bool isLongNoteStart_2 = true;
        bool isLongNoteStart_3 = true;
        bool isLongNoteStart_4 = true;

        float preNoteTime_Ln1 = 0f;
        float preNoteTime_Ln2 = 0f;
        float preNoteTime_Ln3 = 0f;
        float preNoteTime_Ln4 = 0f;

        // 노트 소멸 딜레이 타임.
        float destroyDelayTime = bms.getTotalPlayTime() + 1;

        // Bar 생성.
        float secondPerBar = 60.0f / (float)bms.getBpm() * 4.0f; // Bar 당 시간(초).
        int barCount = 0;
        for (int i = 0; i < bms.totalBarCount; i++)
        {
            // barLine 생성
            float barTime = barCount * secondPerBar; // Bar 시작시간
            note = (GameObject)Instantiate(barPrefab, new Vector3(0, 0.25f, startPositionZ - notePrefab.transform.localScale.z), Quaternion.identity);
            NoteFalling = note.GetComponent<NoteFalling>();
            NoteFalling.speed = defaultSpeed;
            NoteFalling.destroyPositionZ = judgmentPositionZ - destroyDelayPositionZ;
            NoteFalling.destroyDelayTime = destroyDelayTime;
            NoteFalling.noteTime = barTime;
            bar_Line.Add(NoteFalling);
            barCount++;
        }

        // 노트 생성.
        foreach (BarData barData in bms.getBarDataList())
        {
            bool isLongChannel = false;
            int NoteCount = 0;

            int channel = barData.getChannel();
            float Line_1_x = -1.737f;
            float Line_2_x = -0.647f;
            float Line_3_x = 0.622f;
            float Line_4_x = 1.712f;

            if (channel == 51 || channel == 52 || channel == 53 || channel == 54 || channel == 55)
            {
                isLongChannel = true;
            }


            foreach (Dictionary<int, float> noteData in barData.getNoteDataList())
            {
                foreach (int key in noteData.Keys)
                {
                    // 단노트.
                    if (isLongChannel == false && key != 0 && channel != 16)
                    {
                        float noteTime = noteData[key];
                        if (channel == 11)
                        {
                            linePositionX = Line_1_x;
                        }
                        else if (channel == 12)
                        {
                            linePositionX = Line_2_x;
                        }
                        else if (channel == 13)
                        {
                            linePositionX = Line_3_x;
                        }
                        else if (channel == 14)
                        {
                            linePositionX = Line_4_x;
                        }

                        note = (GameObject)Instantiate(notePrefab, new Vector3(linePositionX, 0, startPositionZ), Quaternion.identity);
                        NoteFalling = note.GetComponent<NoteFalling>();
                        NoteFalling.speed = defaultSpeed;
                        NoteFalling.destroyPositionZ = judgmentPositionZ - destroyDelayPositionZ;
                        NoteFalling.destroyDelayTime = destroyDelayTime;
                        NoteFalling.noteTime = noteTime;
                        NoteFalling.channel = channel;
                        NoteCount++;
                        if (channel == 11)
                        {
                            // NoteFalling.particleName = "particle/Effect1";
                            noteObj_Line_1.Add(NoteFalling);
                        }
                        else if (channel == 12)
                        {
                            noteObj_Line_2.Add(NoteFalling);
                        }
                        else if (channel == 13)
                        {
                            noteObj_Line_3.Add(NoteFalling);
                        }
                        else if (channel == 14)
                        {
                            noteObj_Line_4.Add(NoteFalling);
                        }
                    }

                    // 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.// 롱노트.

                    if (isLongChannel == true && key != 0)
                    {
                        float secondPerBeat = 60.0f / (float)bms.getBpm() * 4.0f / beatPerBar; // Beat당 시간(초)
                        float longHeightRate = 0f; // 롱노트 높이 배율.

                        bool isLongNoteStart = false;
                        if (channel == 51)
                        {
                            isLongNoteStart = isLongNoteStart_1;
                            linePositionX = Line_1_x;
                        }
                        else if (channel == 52)
                        {
                            isLongNoteStart = isLongNoteStart_2;
                            linePositionX = Line_2_x;
                        }
                        else if (channel == 53)
                        {
                            isLongNoteStart = isLongNoteStart_3;
                            linePositionX = Line_3_x;
                        }
                        else if (channel == 54)
                        {
                            isLongNoteStart = isLongNoteStart_4;
                            linePositionX = Line_4_x;
                        }

                        if (isLongNoteStart == true)
                        {
                            if (channel == 51)
                            {
                                preNoteTime_Ln1 = noteData[key];
                                isLongNoteStart_1 = false;
                            }
                            else if (channel == 52)
                            {
                                preNoteTime_Ln2 = noteData[key];
                                isLongNoteStart_2 = false;
                            }
                            else if (channel == 53)
                            {
                                preNoteTime_Ln3 = noteData[key];
                                isLongNoteStart_3 = false;
                            }
                            else if (channel == 54)
                            {
                                preNoteTime_Ln4 = noteData[key];
                                isLongNoteStart_4 = false;
                            }
                        }
                        else if (isLongNoteStart == false)
                        {
                            float noteTime = noteData[key];

                            float preNoteTime_Ln = 0f;
                            if (channel == 51)
                            {
                                preNoteTime_Ln = preNoteTime_Ln1;
                            }
                            else if (channel == 52)
                            {
                                preNoteTime_Ln = preNoteTime_Ln2;
                            }
                            else if (channel == 53)
                            {
                                preNoteTime_Ln = preNoteTime_Ln3;
                            }
                            else if (channel == 54)
                            {
                                preNoteTime_Ln = preNoteTime_Ln4;
                            }

                            longHeightRate = (noteTime - preNoteTime_Ln) / secondPerBeat;

                            //print("preNoteTime_Ln = " + preNoteTime_Ln);
                            //print("noteTime = " + noteTime);
                            //print("longHeightRate = " + Mathf.Round(longHeightRate));

                            note = (GameObject)Instantiate(notePrefab, new Vector3(linePositionX, 0, startPositionZ), Quaternion.identity);
                            float originalScaleX = note.transform.localScale.x;
                            float originalScaleY = note.transform.localScale.y;
                            float originalScaleZ = note.transform.localScale.z;
                            note.transform.localScale = new Vector3(originalScaleX, originalScaleY, originalScaleZ * Mathf.Round(longHeightRate) + originalScaleZ);

                            NoteFalling = note.GetComponent<NoteFalling>();
                            NoteFalling.speed = defaultSpeed;
                            NoteFalling.destroyPositionZ = judgmentPositionZ - destroyDelayPositionZ;
                            NoteFalling.destroyDelayTime = destroyDelayTime;
                            NoteFalling.noteTime = preNoteTime_Ln;

                            if (channel == 51)
                            {
                                noteObj_Line_1.Add(NoteFalling);
                                preNoteTime_Ln1 = 0;
                                isLongNoteStart_1 = true;
                            }
                            else if (channel == 52)
                            {
                                noteObj_Line_2.Add(NoteFalling);
                                preNoteTime_Ln2 = 0;
                                isLongNoteStart_2 = true;
                            }
                            else if (channel == 53)
                            {
                                noteObj_Line_3.Add(NoteFalling);
                                preNoteTime_Ln3 = 0;
                                isLongNoteStart_3 = true;
                            }
                            else if (channel == 54)
                            {
                                noteObj_Line_4.Add(NoteFalling);
                                preNoteTime_Ln4 = 0;
                                isLongNoteStart_4 = true;
                            }


                        }
                    }
                }
            }
        }
                
                    noteObj_Line_1.Sort(delegate (NoteFalling a, NoteFalling b)
                    {
                        return a.noteTime.CompareTo(b.noteTime);
                    });
                    noteObj_Line_2.Sort(delegate (NoteFalling a, NoteFalling b)
                    {
                        return a.noteTime.CompareTo(b.noteTime);
                    });
                    noteObj_Line_3.Sort(delegate (NoteFalling a, NoteFalling b)
                    {
                        return a.noteTime.CompareTo(b.noteTime);
                    });
                    noteObj_Line_4.Sort(delegate (NoteFalling a, NoteFalling b)
                    {
                        return a.noteTime.CompareTo(b.noteTime);
                    });
                    bar_Line.Sort(delegate (NoteFalling a, NoteFalling b)
                    {
                        return a.noteTime.CompareTo(b.noteTime);
                    });

                    // 비트 크리에이터.

                    Falling_From FallCreator = GameObject.Find("BeatCreator").GetComponent<Falling_From>();

                    FallCreator.noteObj_Line_1 = noteObj_Line_1;
                    FallCreator.noteObj_Line_2 = noteObj_Line_2;
                    FallCreator.noteObj_Line_3 = noteObj_Line_3;
                    FallCreator.noteObj_Line_4 = noteObj_Line_4;
                    FallCreator.bar_Line = bar_Line;

                    FallCreator.bpm = (float)bms.getBpm();
                    FallCreator.beatPerBar = beatPerBar;
                    FallCreator.timeRateBySpeed = timeRateBySpeed;


                    AudioClip bgm = Resources.Load("BGM/" + bmsName) as AudioClip;
                    FallCreator.bgmSound = bgm; //bmsName에서 이름을 가져간다. 따라서 패턴 이름과 bgm 이름은 일치 해야 한다. 한 곡에 패턴 여러개 만들 때 참고



                    //FallCreator.isTic = isTic;

                    // 모든 렌더링작업이 끝날 때까지 대기

                    yield return new WaitForEndOfFrame();

                    FallCreator.isStart = true; // 시작

                

            
        
    }
}

