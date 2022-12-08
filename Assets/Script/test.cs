using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour
{

    public int _exp = 0;
    int[] ExpArray = new int[100];

    public int a;
    public int b;
    public int c;

    void Start()
    {
        List<Dictionary<string, object>> data = CSVReader.Read("exp");

        for (var i = 0; i < data.Count; i++)
        {
            Debug.Log("index " + (i).ToString() + " : " + data[i]["EXP"] + " " + data[i]["LEVEL"]); //대소문자 구별 철저하게 하셈 ㅜㅜ
        }

        /*
        for (var a = 0; a < data.Count; a++)
        {
            ExpArray[a] = (int)data[a]["EXP"];
            Debug.Log(ExpArray[a]);
        }**/

        a = (int)data[10]["EXP"];
        b = (int)data[11]["EXP"];
        c = (int)data[12]["EXP"];
        ExpArray[0] = (int)data[0]["EXP"];
        print(ExpArray[0]);
        print(a + b + c);

        
        _exp = (int)data[0]["EXP"];
        Debug.Log(_exp);
    }
}
