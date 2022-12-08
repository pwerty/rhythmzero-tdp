using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadNote1 : MonoBehaviour
{
    public GameObject NoteBar;
    void Start()
    {
        ReadFromFile();
    }



    private void ReadFromFile()
    {
        int i = 0;


       
        
         string[] lines = File.ReadAllLines("Assets/BmsFiles/Tutorial.bms");
        
        foreach (string line in lines)
        {

            if (lines == null) return;

            if (lines[i].StartsWith("#"))
            {
                char[] seps = new char[] { ' ', ':' };
                string[] StringList = lines[i].Split(seps);
                // .bms 파일 내에 기록된 정보를 가져옵니다.
                // 장르
                if (StringList[0].Equals("#GENRE"))
                {
                }
                // 아티스트
                else if (StringList[0].Equals("#ARTIST"))
                {
                }
                // 제목
                else if (StringList[0].Equals("#TITLE"))
                {
                }
                // BPM
                else if (StringList[0].Substring(0, 4).Equals("#BPM"))
                {
                }
                // 플레이 레벨
                else if (StringList[0].Equals("#PLAYLEVEL"))
                {
                }
                // 랭크?
                else if (StringList[0].Equals("#RANK"))
                {
                }
                else if (StringList[0].Equals("#STAGEFILE") || StringList[0].Equals("#VOLWAV") || StringList[0].Equals("#LNTYPE"))
                {
                }
                else
                {
                    try
                    {
                        //파싱한 데이터를 BlockProcess 클래스로 보냅니다.
                        int BarNum = GetBarNum(StringList[0]);
                        int ChannelNum = GetChannelNum(StringList[0]);
                        //Debug.Log(BarNum + " + " + ChannelNum + "(" + i + ")" + " = " + StringList[1]);
                        GetComponent<NoteBar>().BlockProcess(ChannelNum, BarNum, StringList[1], "KEY");

                    }//예외 처리
                    catch (System.Exception e)
                    {
                        Debug.Log(e);
                    }
                }
            }
            i++;
        }
        

    }// 데이터 파싱을 진행합니다.
    private int GetBarNum(string data)
    {
        return int.Parse(data.Substring(1, 3));
    }
    private int GetChannelNum(string data)
    {
        return int.Parse(data.Substring(4, 2));
    }
    

    }




