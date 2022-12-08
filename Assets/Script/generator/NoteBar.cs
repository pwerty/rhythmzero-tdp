using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NoteBar : MonoBehaviour
{
    public bool enableSpawn = true;
    public GameObject NoteBar_Line_1;
    public GameObject NoteBar_Line_2;
    public GameObject NoteBar_Line_3;
    public GameObject NoteBar_Line_4;
    public float bpm = 128;
    public float list_number;

    //AudioSource bgmPlayer = GameObject.Find("Camera").GetComponent<AudioSource>();

    public float Line_1_x = -1.737f;
    public float Line_2_x = -0.647f;
    public float Line_3_x = 0.622f;
    public float Line_4_x = 1.712f;

    float beatPerBar = 32f; // Bar 당 비트수.
    int defaultSpeed = 10;
    int timeRateBySpeed = 2; // 거리 계수

    public float default_y = 0;
    public int FallSpeed = 3; //이후 사용자가 직접 조정 할 수 있는 변수중 하나입니다
    public float timeSpan;
    public int ArrayCountSave = 0;
    public ArrayList noteArray = new ArrayList();

    public List<GameObject> noteList_1line;
    public List<GameObject> noteList_2line;
    public List<GameObject> noteList_3line;
    public List<GameObject> noteList_4line;
    public int total;
    // public GameObject[] notes;

    private void Start()
    {
        float secondPerBar = 60.0f / bpm * 4f;                          // Bar 당 시간(초)
        float secondPerBeat = 60.0f / bpm * 4f / beatPerBar;              // Beat 당 시간(초).
     //   float samplePerBar = secondPerBar * bgmPlayer.clip.frequency;     // Bar 당 PCM 샘플.
      //  float samplePerBeat = secondPerBeat * bgmPlayer.clip.frequency;   // Beat 당 PCM 샘플.
    }

    public void BlockProcess(int Chanum, int Barnum, string list_guy, string key)
        
    // Chanum은 내려오는 라인 번호를 정의합니다.
    // Barnum은 마디를 정의합니다.
    // list_guy는 마디 내의 위치 데이터를 정의합니다.
    // key는 아직 사용하지 않습니다.
    /*
     *  (참고자료) 이 때 데이터의 갯수가 n이라고 하면, 마디는 n 조각으로 나뉘게 되고 첫째 데이터는 해당 마디의 0/n 위치(즉, 마디의 시작), 둘째 데이터는 1/n 위치, ..., 
     *  n번째 데이터는 (n-1)/n 위치에 들어 가게 된다. "00"이 들어 왔을 경우 데이터가 없는 것으로 간주하고 무시한다.
     *  */
    {
        int L = 0;
        float BarnumTest = Barnum ;
        float note_space = 0.03125f; // 최소 노트 간격을 정의합니다. Barnum은 마디 번호를 정의하는데, 마디마다 간격 한 마디(1)의 32등분 값인 0.03125으로 합니다.
        if (list_guy.Length == 64) //데이터의 길이를 구별합니다. 제일 길이가 긴 데이터 수치는 64입니다. 데이터 갯수는 2글자에 1개로 정의합니다.
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0; //간격 수치 변수를 초기화 하여 노트를 배치할 준비를 합니다.
            for (L = 0; L < list_guy.Length; L = L + 2) //2개 씩 데이터를 검사합니다.
            {

                if (list_guy.Substring(L, 2) == "00") // 00은 공백을 의미하며 노트를 생성하지 않습니다.
                { 
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space;
                }

                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    // 얻어온 데이터로 노트를 생성할 라인을 정한 후 진행합니다.
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, (list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " + list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
 
                        noteList_1line.Add(generated_01);
 
                    }
                     if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, (list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " + list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, (list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 " +    list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                     if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, (list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 " +   list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space;
                }// 공백을 하나 추가합니다.
                
            }

        }
        
        
       else if (list_guy.Length == 32) 
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0;
            for (L = 0; L < list_guy.Length; L = L + 2)
            {

                if (list_guy.Substring(L, 2) == "00")
                {
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space * 2f; // 최대 수치인 64에 비해 적은 데이터를 가지고 있는 경우 '00' 데이터 하나는 더 긴 간격의 공백을 정의합니다. 나머지 더 적은 데이터 길이의 경우도 해당됩니다.
                }

                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    // 얻어온 데이터로 노트를 생성할 라인을 정한 후 진행합니다.
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " + list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
  
                                   noteList_1line.Add(generated_01);
 
                    }
                    else if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " +  list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    else if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 " +  list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                    else if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 " +  list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space * 2f; //Length * 곱하는 수치가 64가 되어야합니다. 
                     
                }
               

            }
            list_number = list_number + note_space;
        } 
        else if (list_guy.Length == 16)
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0;
            for (L = 0; L < list_guy.Length; L = L + 2)
            {

                if (list_guy.Substring(L, 2) == "00")
                {
                
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space * 4f;

                }
                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    // 얻어온 데이터로 노트를 생성할 라인을 정한 후 진행합니다.
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " +  list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
  
                                   noteList_1line.Add(generated_01);
 
                    }
                    else if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " +  list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    else if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 " +  list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                    else if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 " +   list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space * 4f ;  
                }
            }
        }
        else if (list_guy.Length == 8)
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0;
            for (L = 0; L < list_guy.Length; L = L + 2)
            {

                if (list_guy.Substring(L, 2) == "00")
                {
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space * 8f;
                }

                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    // 얻어온 데이터로 노트를 생성할 라인을 정한 후 진행합니다.
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " +   list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
  
                                   noteList_1line.Add(generated_01);
 
                    }
                    else if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " +  list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    else if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 " +  list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                    else if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 " +  list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space * 8f;  
                }

            }
        }
        else if (list_guy.Length == 4)
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0;
            for (L = 0; L < list_guy.Length; L = L + 2)
            {

                if (list_guy.Substring(L, 2) == "00")
                {
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space * 16f;
                }
                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    // 얻어온 데이터로 노트를 생성할 라인을 정한 후 진행합니다.
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " +list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
  
                                   noteList_1line.Add(generated_01);
 
                    }
                    else if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " +   list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    else if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 " +   list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                    else if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 " +  list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space * 16f;  
                }
                

            }
        }
        else if (list_guy.Length == 2)
        {
            Debug.Log("데이터 갯수는 " + list_guy.Length + "입니다.");
            list_number = 0;
            for (L = 0; L < list_guy.Length; L = L + 2)
            {

                if (list_guy.Substring(L, 2) == "00")
                {
                    Debug.Log("노트 간격을 한차례 늘립니다.");
                    list_number = list_number + note_space * 32f;
                }

                else
                {   // 00이 아닌경우 노트를 생성하게 됩니다.
                    Debug.Log(list_guy.Substring(L, 2) + " 라는 데이터를 얻었습니다. 00이 아니니 노트가 생성됩니다.");
                    if (Chanum == 11)
                    {
                        GameObject generated_01 = Instantiate(NoteBar_Line_1, new Vector3(Line_1_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("1라인 노트 생성 완료 " +  list_number); //'00' 데이터를 통해 늘린 list_number와 마디를 구분하는 Barnum을 더한 후 노트를 배치합니다. 
  
                                   noteList_1line.Add(generated_01);
 
                    }
                    else if (Chanum == 12)
                    {
                        GameObject generated_02 = Instantiate(NoteBar_Line_2, new Vector3(Line_2_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("2라인 노트 생성 완료 " + list_number);
  
                                   noteList_2line.Add(generated_02);
 
                    }
                    else if (Chanum == 13)
                    {
                        GameObject generated_03 = Instantiate(NoteBar_Line_3, new Vector3(Line_3_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("3라인 노트 생성 완료 "  + list_number);
  
                                   noteList_3line.Add(generated_03);
 
                    }
                    else if (Chanum == 14)
                    {
                        GameObject generated_04 = Instantiate(NoteBar_Line_4, new Vector3(Line_4_x, default_y, ( list_number + BarnumTest) * FallSpeed), Quaternion.identity);
                        Debug.Log("4라인 노트 생성 완료 "  + list_number);
  
                                   noteList_4line.Add(generated_04);
 
                    }
                    list_number = list_number + note_space * 32f;  
                }
              
            }


        }
        else
        {
            print("정상 배열이 진행되지 않은 노트입니다. 데이터 배열에 이상한 내용이 있는 것 같습니다.");
            Debug.Log("노트 데이터 " + list_guy);
        }
                 // ArrayCountSave = noteArray.Count;
        print("파싱 완료! 노트 출력이 모두 끝났습니다.");
        total = noteList_1line.Count + noteList_2line.Count + noteList_3line.Count + noteList_4line.Count; //총합 노트의 갯수는 몇개인가?
    }

}



