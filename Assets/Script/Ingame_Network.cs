using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ingame_Network : Photon.MonoBehaviour {
    // 네트워크 총 관리 스크립트, 더미 데이터도 많습니다.

    static public bool IsEnemyReady = false;
    static public bool Am_I_Ready = false;

   static public bool NetworkReady;

    static public  int playerWhoIsIt;
    static public  PhotonView photonView;

    public Text Enemy_MaxCOMBO;
    public Text Enemy_BOOST;
    public Text Enemy_Score;

    static public int Enemy_Combo_Value;
    static public int Enemy_Boost_Value = 1;
    static public int Enemy_Score_Value;

    static public int BoostX_Value;


    public string gameVersion = "0.1";

    private void Awake()
    {
        photonView = this.GetComponent<PhotonView>();
       // if (SceneManager.GetActiveScene().name == "abc")
       // {
            NetworkReady = true;
       // }
    }

    [PunRPC]
    void TaggedPlayer(int playerID)
    {
        playerWhoIsIt = playerID;
        Debug.Log("TaggedPlayer: " + playerID);
    }


    //PunRPC로 상대 컴퓨터에 나의 상태를 보냄


    [PunRPC]
    void Enemy_MaxCombo_Count()
    {
        Enemy_Combo_Value++;
    }

    [PunRPC]
    void Enemy_Boost_Count()
    {
        Enemy_Boost_Value++;
    }

    [PunRPC]
    void Enemy_SCORE_CountA()
    {
        Enemy_Score_Value = Enemy_Score_Value + 100;
    }

    [PunRPC]
    void Enemy_SCORE_CountB()
    {
        Enemy_Score_Value = Enemy_Score_Value + 85;
    }

    [PunRPC]
    void Enemy_SCORE_CountC()
    {
        Enemy_Score_Value = Enemy_Score_Value + 50;
    }

    [PunRPC]
    void Enemy_SCORE_CountD()
    {
        Enemy_Score_Value = Enemy_Score_Value + 25;
    }

    [PunRPC]
    void Enemy_SCORE_CountE()
    {
        Enemy_Score_Value = Enemy_Score_Value + 10;
    }
    //Combo.BoostX 값을 가져오면 0으로 쳐버림. Combo.cs 참고 
    
    [PunRPC]
    void Ready()
    {
        IsEnemyReady = true;
    }

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(gameVersion);
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("이미 만들어진 방이 없음");

        RoomOptions option = new RoomOptions();

        option.IsVisible = true;
        option.IsOpen = true;
        option.MaxPlayers = 4;

        PhotonNetwork.CreateRoom("roomName", option, TypedLobby.Default);

    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    void OnJoinedRoom()
    {
        Debug.Log("Joined");


        if (PhotonNetwork.playerList.Length == 1)
        {
            playerWhoIsIt = PhotonNetwork.player.ID;
        }

        Debug.Log("player who " + playerWhoIsIt);
    }


    void OnPhotonPlayerConnected(PhotonPlayer player)
    {
        Debug.Log("OnPhotonPlayerConneted! " + player);

    }


    static public void EnemyCombo()
    {
        if(NetworkReady == true)
        {
            photonView.RPC("Enemy_MaxCombo_Count", PhotonTargets.Others);
        }
      
    }

    static public void EnemyBOOST()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_Boost_Count", PhotonTargets.Others);
        }

    }

    static public void EnemyScoreA()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_SCORE_CountA", PhotonTargets.Others);
        }

    }


    static public void EnemyScoreB()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_SCORE_CountB", PhotonTargets.Others);
        }

    }


    static public void EnemyScoreC()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_SCORE_CountC", PhotonTargets.Others);
        }

    }


    static public void EnemyScoreD()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_SCORE_CountD", PhotonTargets.Others);
        }

    }


    static public void EnemyScoreE()
    {
        if (NetworkReady == true)
        {
            photonView.RPC("Enemy_SCORE_CountE", PhotonTargets.Others);
        }

    }


    static public void LetsGo()
    {
        photonView.RPC("Ready", PhotonTargets.Others);
    }
 

    private void Update()
    {
        BoostX_Value = Combo.BoostX;
        print(BoostX_Value);

        
        PhotonNetwork.player.NickName = "2222";

        Enemy_MaxCOMBO.text = Enemy_Combo_Value.ToString();
        Enemy_BOOST.text = Enemy_Boost_Value.ToString();
        Enemy_Score.text = Enemy_Score_Value.ToString();


        if (Am_I_Ready == true)
        {
            LetsGo();
        }
    }
}
