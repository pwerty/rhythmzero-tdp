using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour {

    public GameObject JudgeA;
    public GameObject JudgeB;
    public GameObject JudgeC;
    public GameObject JudgeD;
    public GameObject JudgeE;
    public GameObject JudgeF;

    public GameObject JudgeA_Particle;

    void Start () {
		
	}
	

	void Update () {

        if (this.GetComponent<Animation>().isPlaying == false)
        {
            this.gameObject.SetActive(false);
        }

    }
    public void Judges()
    {
        this.gameObject.SetActive(true);
        this.GetComponent<Animation>().Rewind("Judge_A");
        this.GetComponent<Animation>().Play("Judge_A");
        if (this.name == "PPAP")
        {
            float playbackTime = JudgeA_Particle.GetComponent<ParticleSystem>().time;
            JudgeA_Particle.GetComponent<ParticleSystem>().Clear();
            JudgeA_Particle.GetComponent<ParticleSystem>().Simulate(playbackTime - Time.deltaTime);
            JudgeA_Particle.GetComponent<ParticleSystem>().Play();
            if (JudgeB.activeSelf == true)
            {
                JudgeB.SendMessage("Judge_Stop");
            }
            if(JudgeC.activeSelf == true)
            {
                JudgeC.SendMessage("Judge_Stop");
            }
            if (JudgeD.activeSelf == true)
            {
                JudgeD.SendMessage("Judge_Stop");
            }
            if (JudgeE.activeSelf == true)
            {
                JudgeE.SendMessage("Judge_Stop");
            }
            if (JudgeF.activeSelf == true)
            {
                JudgeF.SendMessage("Judge_Stop");
            }
        }
        else if (this.name == "PPBP")
        {

            if (JudgeA.activeSelf == true)
            {
                JudgeA.SendMessage("Judge_Stop");
            }

            if (JudgeC.activeSelf == true)
            {
                JudgeC.SendMessage("Judge_Stop");
            }
            if (JudgeD.activeSelf == true)
            {
                JudgeD.SendMessage("Judge_Stop");
            }
            if (JudgeE.activeSelf == true)
            {
                JudgeE.SendMessage("Judge_Stop");
            }
            if (JudgeF.activeSelf == true)
            {
                JudgeF.SendMessage("Judge_Stop");
            }
        }
        else if (this.name == "PPCP")
        {

            if (JudgeA.activeSelf == true)
            {
                JudgeA.SendMessage("Judge_Stop");
            }
            if (JudgeB.activeSelf == true)
            {
                JudgeB.SendMessage("Judge_Stop");
            }

            if (JudgeD.activeSelf == true)
            {
                JudgeD.SendMessage("Judge_Stop");
            }
            if (JudgeE.activeSelf == true)
            {
                JudgeE.SendMessage("Judge_Stop");
            }
            if (JudgeF.activeSelf == true)
            {
                JudgeF.SendMessage("Judge_Stop");
            }
        }
        else if (this.name == "PPDP")
        {
            if (JudgeA.activeSelf == true)
            {
                JudgeA.SendMessage("Judge_Stop");
            }
            if (JudgeB.activeSelf == true)
            {
                JudgeB.SendMessage("Judge_Stop");
            }
            if (JudgeC.activeSelf == true)
            {
                JudgeC.SendMessage("Judge_Stop");
            }

            if (JudgeE.activeSelf == true)
            {
                JudgeE.SendMessage("Judge_Stop");
            }
            if (JudgeF.activeSelf == true)
            {
                JudgeF.SendMessage("Judge_Stop");
            }
        }
        else if (this.name == "PPEP")
        {
            if (JudgeA.activeSelf == true)
            {
                JudgeA.SendMessage("Judge_Stop");
            }
            if (JudgeB.activeSelf == true)
            {
                JudgeB.SendMessage("Judge_Stop");
            }
            if (JudgeC.activeSelf == true)
            {
                JudgeC.SendMessage("Judge_Stop");
            }
            if (JudgeD.activeSelf == true)
            {
                JudgeD.SendMessage("Judge_Stop");
            }

            if (JudgeF.activeSelf == true)
            {
                JudgeF.SendMessage("Judge_Stop");
            }
        }
        else
        {
            if (JudgeA.activeSelf == true)
            {
                JudgeA.SendMessage("Judge_Stop");
            }
            if (JudgeB.activeSelf == true)
            {
                JudgeB.SendMessage("Judge_Stop");
            }
            if (JudgeC.activeSelf == true)
            {
                JudgeC.SendMessage("Judge_Stop");
            }
            if (JudgeD.activeSelf == true)
            {
                JudgeD.SendMessage("Judge_Stop");
            }
            if (JudgeE.activeSelf == true)
            {
                JudgeE.SendMessage("Judge_Stop");
            }       
        }
    }

    public void Judge_Stop()
    {
        this.gameObject.SetActive(false);

    }
}
        

        // Rewind 후 Play를 하여 애니메이션이 재생되는 동안에 노트를 처리했을때 애니메이션이 새로 재생되지 않는 현상을 방지했습니다.


   

