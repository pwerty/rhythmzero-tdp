using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using UnityEngine.UI;

public class Super12 : Photon.PunBehaviour {

    /*
     * 
    public GameObject Count;

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1");
       // PhotonView photonView = PhotonView.Get(this);
    }

    [PunRPC]
     void HowManyFail(string haha)
    {
        Count.GetComponent<Text>().text = haha.ToString();

    }



    // Update is called once per frame
    void Update() {
        PhotonNetwork.player.NickName = "1111";

       

      

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't");
        PhotonNetwork.CreateRoom(null);
    }
    /*
    public void SendGuy()
    {
        print(PhotonNetwork.)
    }
    */


    
   
}
