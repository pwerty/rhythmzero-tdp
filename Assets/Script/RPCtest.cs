using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using UnityEngine.Video;
using UnityEngine.UI;

public class RPCtest : Photon.MonoBehaviour
{
    /*
    public static Super12 Super;
    public List<string> messages = new List<string>();

    private int chatHeight = (int)140;
    private Vector2 scrollPos = Vector2.zero;
    private string chatInput = "";
    
    void Awake()
    {
        Super = this;  
    }

    [PunRPC]
    void ChatMessage(string a)
    {
        Debug.Log("ChatMessage " + a);
    }
  


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("ChatMessage", PhotonTargets.AllViaServer, "ChatMessage Testing");

    }
    */
    public static int playerWhoIsIt;
    public static PhotonView PhotonView;


    public GameObject Count;

    public string gameVersion = "0.1";
    public AudioSource AudioPlayer;
    public VideoPlayer VideoPlayer;
    public Text Searching;
    public GameObject Idle_Turning_cube;

    public int Rating = 1200;
    public int Enemy_Rating;

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

        AudioPlayer.Play();
        VideoPlayer.Play();
        Searching.gameObject.SetActive(true);
        Idle_Turning_cube.SetActive(true);

        if (PhotonNetwork.playerList.Length == 1)
        {
            playerWhoIsIt = PhotonNetwork.player.ID;
        }

        Debug.Log("player who " + playerWhoIsIt);
    }


    void OnPhotonPlayerConnected(PhotonPlayer player)
    {
        Debug.Log("OnPhotonPlayerConneted! " + player);

        if (PhotonNetwork.isMasterClient)
        {
            TagPlayer(playerWhoIsIt);
        }
    }

    public static void TagPlayer(int playerID)
    {
        Debug.Log("TagPlayer :" + playerID);
        PhotonView.RPC("TaggedPlayer", PhotonTargets.All, playerID);
    }

    public void GOGOGO()
    {
        Debug.Log("Search Start");
        PhotonView.RPC("FindMatchFromRating", PhotonTargets.Others, Rating);
    }

    [PunRPC]
    void TaggedPlayer(int playerID)
    {
        playerWhoIsIt = playerID;
        Debug.Log("TaggedPlayer: " + playerID);
    }

    [PunRPC]
    void FindMatchFromRating(int rating)
    {
        Enemy_Rating = rating;
    }

    private void Update()
    {
        if (Enemy_Rating == Rating)
        {
            Debug.Log("적합한 상대를 찾았습니다. 경기를 시작합니다!");
        }

        if (PhotonNetwork.countOfPlayersInRooms > 1)
        {

            Count.GetComponent<Text>().text = ("PLAYER COUNT : " + PhotonNetwork.countOfPlayersInRooms);
        }
        else
        {
            Count.GetComponent<Text>().text = ("PLAYER NAME : " + PhotonNetwork.player.NickName);
        }
    }
}

