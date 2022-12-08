using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Particle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "note_line1")
        {
            //파티클 생성시킨다
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
